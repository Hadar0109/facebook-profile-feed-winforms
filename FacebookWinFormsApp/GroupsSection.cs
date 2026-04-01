using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class GroupsSection : BaseFeedSection<Group>
    {
        public GroupsSection(User i_LoggedInUser) : base(i_LoggedInUser) { }

        public override string DisplayMember => "Name";

        protected override IEnumerable<Group> FetchSectionData()
        {
            IEnumerable<Group> result = null;

            try
            {
                result = r_LoggedInUser?.Groups;
            }
            catch (Exception)
            {
                // Error messages are handled by the UI (ProfileFeed) to maintain Separation of Logic and UI
            }

            return result;
        }

    }
}
