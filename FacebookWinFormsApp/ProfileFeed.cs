using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class ProfileFeed : Form, IObserver
    {
        public event Action ActionToLogout;
        public event Action ActionToSwitchUser;

        private readonly User r_LoggedInUser;
        private readonly SlideShowLogic r_SlideShowLogic;
        private FeedContext m_FeedContext;
        private IProfileFeedSection m_CurrentSection;

        public ProfileFeed(User i_LoggedInUser)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            r_LoggedInUser = i_LoggedInUser;
            r_SlideShowLogic = new SlideShowLogic();

            fetchUserInfo();
            registerEventListeners();
            hideAllPanels();

            SavedItemsManager.Instance.Attach(this);
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);

            labelProfileName.Text = r_LoggedInUser.Name;
            labelProfileName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            labelProfileName.AutoSize = true;

            int topProfileFeed = pictureBoxProfile.Location.X + (pictureBoxProfile.Width - labelProfileName.Width) / 2;
            int bottomProfileFeed = labelProfileName.Location.Y;

            labelProfileName.Location = new Point(topProfileFeed, bottomProfileFeed);
        }

        private void registerEventListeners()
        {
            albumBindingSource.CurrentChanged += albumBindingSource_CurrentChanged;
            r_SlideShowLogic.CurrentPhotoChanged += onSlideshowPhotoChanged;
            postBindingSource.CurrentChanged += postBindingSource_CurrentChanged;
        }

        private void hideAllPanels()
        {
            pagePanel.Visible = false;
            postPanel.Visible = false;
            friendPanel.Visible = false;
            groupPanel.Visible = false;
            aboutPanel.Visible = false;
            albumPanel.Visible = false;
            flowLayoutPanelSavedPosts.Visible = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            OnLogoutRequested();
            this.Close();
        }

        protected virtual void OnLogoutRequested()
        {
            if (ActionToLogout != null)
            {
                ActionToLogout.Invoke();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OnLogInRequested();
            this.Close();
        }

        protected virtual void OnLogInRequested()
        {
            if (ActionToSwitchUser != null)
            {
                ActionToSwitchUser.Invoke();
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("Albums", albumBindingSource, albumPanel);
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("Groups", groupBindingSource, groupPanel);
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("Pages", pageBindingSource, pagePanel);
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("Friends", friendListBindingSource, friendPanel);
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("Posts", postBindingSource, postPanel);
        }

        private void buttonFetchAbout_Click(object sender, EventArgs e)
        {
            createAndLoadViaContext("About", userBindingSource, aboutPanel);
        }

        private void createAndLoadViaContext(string i_SectionName, BindingSource i_BindingSource, Panel i_PanelToShow)
        {
            hideAllPanels();

            m_CurrentSection = SectionFactory.CreateSection(i_SectionName, r_LoggedInUser, r_SlideShowLogic);

            if (m_FeedContext == null)
            {
                m_FeedContext = new FeedContext(m_CurrentSection);
            }
            else
            {
                m_FeedContext.Strategy = m_CurrentSection;
            }

            new Thread(() => loadViaContextAndUpdateUI(i_BindingSource, i_PanelToShow)).Start();
        }

        private void loadViaContextAndUpdateUI(BindingSource i_BindingSource, Panel i_PanelToShow)
        {
            SectionLoadResult sectionLoadResult = m_FeedContext.LoadCurrentSection();

            if (!mainListBox.InvokeRequired)
            {
                displaySectionContent(sectionLoadResult, i_BindingSource, i_PanelToShow);
            }
            else
            {
                mainListBox.Invoke(new Action(() => displaySectionContent(sectionLoadResult, i_BindingSource, i_PanelToShow)));
            }
        }

        private void displaySectionContent(SectionLoadResult i_Result, BindingSource i_BindingSource, Panel i_PanelToShow)
        {
            if (i_Result.HasData)
            {
                i_BindingSource.DataSource = i_Result.DataSource;
                mainListBox.DataSource = i_BindingSource;
                mainListBox.DisplayMember = i_Result.DisplayMember;

                mainListBox.Visible = true;
                i_PanelToShow.Visible = true;
                i_PanelToShow.BringToFront();
            }
            else
            {
                mainListBox.Visible = false;
                // Using Reflection (GetType) to extract the section name
                MessageBox.Show(string.Format("No items found for {0} :(", i_Result.StrategyName.Replace("Section", "")));
            }
        }

        private void buttonFetchSavedPosts_Click(object sender, EventArgs e)
        {
            hideAllPanels();

            m_CurrentSection = SectionFactory.CreateSection("SavedPosts", r_LoggedInUser, r_SlideShowLogic);

            if (m_FeedContext == null)
            {
                m_FeedContext = new FeedContext(m_CurrentSection);
            }
            else
            {
                m_FeedContext.Strategy = m_CurrentSection;
            }

            flowLayoutPanelSavedPosts.Controls.Clear();

            new Thread(() => loadSavedPostsViaContextAndUpdateUI()).Start();
        }

        private void loadSavedPostsViaContextAndUpdateUI()
        {
            SectionLoadResult sectionLoadResult = m_FeedContext.LoadCurrentSection();

            if (!flowLayoutPanelSavedPosts.InvokeRequired)
            {
                displaySavedPosts(sectionLoadResult);
            }
            else
            {
                flowLayoutPanelSavedPosts.Invoke(new Action(() => displaySavedPosts(sectionLoadResult)));
            }
        }

        private void displaySavedPosts(SectionLoadResult i_SectionLoadResult)
        {
            mainListBox.Visible = false;

            if (i_SectionLoadResult.HasData && m_CurrentSection is SavedPostsSection savedSection)
            {
                foreach (SavedItem savedItem in savedSection.SavedItems)
                {
                    Panel savedPostPanel = SavedPostUI.CreatePostPanel(savedItem, flowLayoutPanelSavedPosts.Width);
                    Button removeButton = savedPostPanel.Controls["unsaveButton"] as Button;

                    if (removeButton != null)
                    {
                        removeButton.Tag = savedItem;
                        removeButton.Click += buttonUnsave_Click;
                    }

                    flowLayoutPanelSavedPosts.Controls.Add(savedPostPanel);
                }

                flowLayoutPanelSavedPosts.Visible = true;
                flowLayoutPanelSavedPosts.BringToFront();
            }
            else
            {
                MessageBox.Show("No saved items found :(");
            }
        }

        public void Update()
        {
            onSavedItemsChanged();
        }

        private void onSavedItemsChanged()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => onSavedItemsChanged()));
            }
            else
            {
                updateSaveButtonState();
            }
        }

        private void updateSaveButtonState()
        {
            Post currentPost = postBindingSource.Current as Post;

            if (currentPost == null)
            {
                saveButton.Enabled = false;

                return;
            }

            bool isSaved = SavedItemsManager.Instance.IsItemSaved(currentPost.Id);

            if (isSaved)
            {
                saveButton.Text = "Saved!";
                saveButton.Enabled = false;
                saveButton.BackColor = Color.LightGray;
            }
            else
            {
                saveButton.Text = "Save Post";
                saveButton.Enabled = true;
                saveButton.BackColor = Color.White;
            }
        }

        private void postBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            updateSaveButtonState();
        }

        private void buttonUnsave_Click(object sender, EventArgs e)
        {
            Button clickedUnsaveButton = sender as Button;
            SavedItem itemToRemove = clickedUnsaveButton.Tag as SavedItem;

            if (itemToRemove != null && m_CurrentSection is SavedPostsSection savedPostsSection)
            {
                savedPostsSection.RemoveSavedPost(itemToRemove);

                Panel panelToRemove = clickedUnsaveButton.Parent as Panel;

                if (panelToRemove != null)
                {
                    flowLayoutPanelSavedPosts.Controls.Remove(panelToRemove);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Post selectedPost = postBindingSource.Current as Post;

            if (selectedPost == null)
            {
                MessageBox.Show("Please select a post");

                return;
            }

            string category = SavedPostUI.SelectCategoryFromDialog();

            if (m_CurrentSection is PostsSection postsSection)
            {
                SavedItem newItem = postsSection.CreateSavedPost(selectedPost, category);

                postsSection.AddSavedPost(newItem);
                MessageBox.Show("Post saved successfully");
            }
        }

        private void buttonPlaySlide_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = albumBindingSource.Current as Album;

            if (selectedAlbum != null && m_CurrentSection is AlbumsSection albums)
            {
                albums.PlaySlideshow(selectedAlbum);
            }
        }

        private void buttonStopSlide_Click(object sender, EventArgs e)
        {
            if (m_CurrentSection is AlbumsSection albums)
            {
                albums.StopSlideshow();
            }
        }

        private void albumBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (m_CurrentSection is AlbumsSection albumsSection)
            {
                albumsSection.StopSlideshow();
            }

            Album selectedAlbum = albumBindingSource.Current as Album;

            if (selectedAlbum == null)
            {
                albumPictureBox.Image = null;
                buttonPlaySlide.Enabled = false;
            }
            else
            {
                albumPictureBox.LoadAsync(selectedAlbum.PictureSmallURL);
                buttonPlaySlide.Enabled = true;
            }
        }

        private void onSlideshowPhotoChanged(string i_ImageUrl)
        {
            albumPictureBox.LoadAsync(i_ImageUrl);
        }
    }
}
