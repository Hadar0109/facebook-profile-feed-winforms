using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public sealed class SavedItemsManager
    {
        private static volatile SavedItemsManager s_Instance = null;
        private static readonly object sr_LockObj = new object();

        private readonly List<SavedItem> r_SavedItems;
        private readonly object r_ListLock = new object();

        private readonly List<IObserver> m_Observers = new List<IObserver>();

        private SavedItemsManager()
        {
            r_SavedItems = new List<SavedItem>();
        }

        public static SavedItemsManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new SavedItemsManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void Attach(IObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void Detach(IObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        private void notify()
        {
            foreach (IObserver observer in m_Observers)
            {
                observer.Update();
            }
        }

        public void AddSavedItem(SavedItem i_SavedItem)
        {
            lock (r_ListLock)
            {
                r_SavedItems.Add(i_SavedItem);
            }

            notify();
        }

        public void RemoveSavedItem(SavedItem i_SavedItem)
        {
            lock (r_ListLock)
            {
                r_SavedItems.Remove(i_SavedItem);
            }

            notify();
        }

        public List<SavedItem> GetAllSavedItems()
        {
            lock (r_ListLock)
            {
                return new List<SavedItem>(r_SavedItems);
            }
        }

        public bool IsItemSaved(string i_SavedItemId)
        {
            lock (r_ListLock)
            {
                bool isItemSaved = false;

                foreach (SavedItem savedItem in r_SavedItems)
                {
                    if (savedItem.Id == i_SavedItemId)
                    {
                        isItemSaved = true;
                        break;
                    }
                }

                return isItemSaved;
            }
        }
    }
}
