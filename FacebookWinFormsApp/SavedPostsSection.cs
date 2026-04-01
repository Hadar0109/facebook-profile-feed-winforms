using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class SavedPostsSection : BaseFeedSection<SavedItem>
    {
        public SavedPostsSection() : base(null) { }

        public override string DisplayMember => "Content";

        public List<SavedItem> SavedItems => m_DataList;

        protected override IEnumerable<SavedItem> FetchSectionData()
        {
            return SavedItemsManager.Instance.GetAllSavedItems();
        }

        public void RemoveSavedPost(SavedItem i_Item)
        {
            SavedItemsManager.Instance.RemoveSavedItem(i_Item);
        }
    }
}