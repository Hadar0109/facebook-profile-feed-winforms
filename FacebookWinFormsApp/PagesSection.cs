using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class PagesSection : BaseFeedSection<Page>
    {
        public PagesSection(User i_LoggedInUser) : base(i_LoggedInUser) { }

        public override string DisplayMember => "Name";

        protected override IEnumerable<Page> FetchSectionData()
        {
            return r_LoggedInUser?.LikedPages;
        }
    }
}