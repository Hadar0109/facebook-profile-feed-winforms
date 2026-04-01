using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class SlideShowLogic
    {
        public event Action<string> CurrentPhotoChanged;
        private List<IImageSource> m_ItemsToPlay;
        private readonly Timer r_SlideshowTimer;
        private int m_CurrentPhotoIndex = 0;

        public SlideShowLogic()
        {
            r_SlideshowTimer = new Timer();
            r_SlideshowTimer.Interval = 2000;
            r_SlideshowTimer.Tick += timer_Tick;
        }

        public void StartSlideshow(List<IImageSource> i_ItemsToPlay)
        {
            if (i_ItemsToPlay != null && i_ItemsToPlay.Count > 0)
            {
                m_ItemsToPlay = i_ItemsToPlay;
                m_CurrentPhotoIndex = 0;

                r_SlideshowTimer.Start();
                onImageChanged();
            }
            else
            {
                StopSlideshow();
            }
        }

        public void StopSlideshow()
        {
            r_SlideshowTimer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (m_ItemsToPlay != null && m_ItemsToPlay.Count > 0)
            {
                // Use modulo to loop back to the first image when reaching the end of the list
                m_CurrentPhotoIndex = (m_CurrentPhotoIndex + 1) % m_ItemsToPlay.Count;
                onImageChanged();
            }
        }

        private void onImageChanged()
        {
            string imageUrl = m_ItemsToPlay[m_CurrentPhotoIndex].GetImageUrl();

            if (CurrentPhotoChanged != null)
            {
                CurrentPhotoChanged.Invoke(imageUrl);
            }
        }
    }
}
