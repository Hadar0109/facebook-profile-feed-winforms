using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class PostsSection : BaseFeedSection<Post>
    {
        public PostsSection(User i_LoggedInUser) : base(i_LoggedInUser) { }

        public override string DisplayMember => "Message";

        protected override IEnumerable<Post> FetchSectionData()
        {
            return r_LoggedInUser?.Posts;
        }

        protected override bool ShouldAddItem(Post i_Post)
        {
            return !string.IsNullOrEmpty(i_Post.Message);
        }

        public SavedItem CreateSavedPost(Post i_SelectedPost, string i_PostCategory)
        {
            return new SavedItem(i_SelectedPost.Id, i_SelectedPost.Message, i_SelectedPost.PictureURL, i_PostCategory);
        }

        public void AddSavedPost(SavedItem i_SavedItem)
        {
            SavedItemsManager.Instance.AddSavedItem(i_SavedItem);
        }

        public bool IsPostSaved(string i_SavedItemId)
        {
            return SavedItemsManager.Instance.IsItemSaved(i_SavedItemId);
        }
    }
}