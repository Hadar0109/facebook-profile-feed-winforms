using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class AboutSection : BaseFeedSection<User>
    {
        public AboutSection(User i_LoggedInUser) : base(i_LoggedInUser) { }

        public override string DisplayMember => "Name";

        protected override IEnumerable<User> FetchSectionData()
        {
            IEnumerable<User> result = null;

            if (r_LoggedInUser != null)
            {
                result = new List<User> { r_LoggedInUser };
            }

            return result;
        }
    }
}