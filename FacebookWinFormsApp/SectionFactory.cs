using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class SectionFactory
    {
        public static IProfileFeedSection CreateSection(string i_SectionType, User i_User, SlideShowLogic i_SlideShow)
        {
            IProfileFeedSection currentSection = null;

            if (i_SectionType == "Posts")
            {
                currentSection = new PostsSection(i_User);
            }
            else if (i_SectionType == "Albums")
            {
                currentSection = new AlbumsSection(i_User, i_SlideShow);
            }
            else if (i_SectionType == "Friends")
            {
                currentSection = new FriendsSection(i_User);
            }
            else if (i_SectionType == "Groups")
            {
                currentSection = new GroupsSection(i_User);
            }
            else if (i_SectionType == "Pages")
            {
                currentSection = new PagesSection(i_User);
            }
            else if (i_SectionType == "About")
            {
                currentSection = new AboutSection(i_User);
            }
            else if (i_SectionType == "SavedPosts")
            {
                currentSection = new SavedPostsSection();
            }

            return currentSection;
        }
    }
}
