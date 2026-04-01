using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class AlbumsSection : BaseFeedSection<Album>
    {
        private readonly SlideShowLogic r_SlideShowLogic;

        public AlbumsSection(User i_LoggedInUser, SlideShowLogic i_SlideShowLogic) : base(i_LoggedInUser)
        {
            r_SlideShowLogic = i_SlideShowLogic;
        }

        public override string DisplayMember => "Name";

        protected override IEnumerable<Album> FetchSectionData()
        {
            return r_LoggedInUser?.Albums;
        }

        public void PlaySlideshow(Album i_SelectedAlbum)
        {
            try
            {
                if (i_SelectedAlbum != null && i_SelectedAlbum.Photos.Count > 0)
                {
                    List<IImageSource> images = new List<IImageSource>();

                    foreach (Photo photo in i_SelectedAlbum.Photos)
                    {
                        images.Add(new FacebookPhotoAdapter { Adoptee = photo });
                    }

                    r_SlideShowLogic.StartSlideshow(images);
                }
            }
            catch (Exception) 
            {
                // Error messages are handled by the UI (ProfileFeed) to maintain Separation of Logic and UI
            }
        }

        public void StopSlideshow()
        {
            r_SlideShowLogic.StopSlideshow();
        }
    }
}