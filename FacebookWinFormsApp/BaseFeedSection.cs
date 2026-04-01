using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public abstract class BaseFeedSection<T> : IProfileFeedSection
    {
        protected readonly User r_LoggedInUser;
        protected List<T> m_DataList;

        public object DataSource => m_DataList;
        public abstract string DisplayMember { get; }

        protected BaseFeedSection(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_DataList = new List<T>();
        }

        public bool Load()
        {
            m_DataList.Clear();

            IEnumerable<T> sectionItems = FetchSectionData();

            if (sectionItems != null)
            {
                foreach (T item in sectionItems)
                {
                    if (ShouldAddItem(item))
                    {
                        m_DataList.Add(item);
                    }
                }
            }

            return m_DataList.Count > 0;
        }

        protected abstract IEnumerable<T> FetchSectionData();

        protected virtual bool ShouldAddItem(T i_Item)
        {
            return true;
        }
    }
}