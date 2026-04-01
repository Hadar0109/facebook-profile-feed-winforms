using System;

namespace BasicFacebookFeatures
{
    public class SavedItem
    {
        public string Id { get; }
        public string Content { get; }
        public string ImageUrl { get; }
        public string Category { get; }
        public DateTime SavedAt { get; }

        public SavedItem(string i_SavedItemId, string i_SavedItemContent, string i_SavedItemImageUrl, string i_SavedItemCategory)
        {
            Id = i_SavedItemId;
            Content = i_SavedItemContent;
            ImageUrl = i_SavedItemImageUrl;
            Category = i_SavedItemCategory;
            SavedAt = DateTime.Now;
        }
    }
}
