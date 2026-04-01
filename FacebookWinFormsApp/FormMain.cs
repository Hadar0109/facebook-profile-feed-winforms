using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        LoginResult m_LoginResult;
        User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();

            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                
                /// id
                "3005731226280421",
                /// requested permissions:
                "email",
                "public_profile",
                "user_posts",
                "user_photos",
                "user_events",
                "user_friends",
                "user_birthday",
                "user_hometown",
                "user_location",
                "user_gender",
                "user_likes"
                //These permissions are currently unavailable:
                //"user_about_me",
                //"user_age_range",
                //"user_relationship",
                //"user_education_history",
                //"user_work_history"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                afterLogin();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBQTAa3rRgO39UZCIJLeD9OpF5SYAevqSaFI16sfjT6JznpAUbyX5Soyj4Uv2ZBRkesoHO9omNcJ3KSYPZCExgaKrIprACUMIVnhiHzT5a46zbdC2VkvZC04n1ZARj8WmvOCYyuIdmRZBNjtWZCFJrbjFoms5t3sU8G9dO1xDCYH7kkfU67heIUZCFDIuTtL0CzF2JUHBpRpwPdXYilOJW811z3C5fY9TOyBiUwZAqx4ZAV6YS5ZBBtYKdsb7");
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                afterLogin();
            }
            catch (Exception ex)
            {
                string errorMessage = (m_LoginResult != null) ? m_LoginResult.ErrorMessage : ex.Message;

                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void afterLogin()
        {
            if (m_LoginResult == null || m_LoggedInUser == null)
            {
                MessageBox.Show("Login failed: no logged-in user was returned from Facebook.", "Login Failed");
                
                return;
            }

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.Visible = true;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;

            ProfileFeed userFeed = new ProfileFeed(m_LoggedInUser);

            userFeed.ActionToLogout += profileFeedLogoutAction;
            userFeed.ActionToSwitchUser += profileFeedSwitchUserAction;

            userFeed.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();

            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            pictureBoxProfile.Visible = false;
        }

        private void profileFeedLogoutAction()
        {
            FacebookService.LogoutWithUI();

            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            pictureBoxProfile.Visible = false;
        }

        private void profileFeedSwitchUserAction()
        {
            FacebookService.LogoutWithUI();

            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            pictureBoxProfile.Visible = false;

            login();
        }
    }
}
