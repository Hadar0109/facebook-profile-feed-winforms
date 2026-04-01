using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FriendsSection : BaseFeedSection<User>
    {
        public FriendsSection(User i_LoggedInUser) : base(i_LoggedInUser) { }

        public override string DisplayMember => "Name";

        protected override IEnumerable<User> FetchSectionData()
        {
            return r_LoggedInUser?.Friends;
        }
    }
}