using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public class FacebookPhotoAdapter : IImageSource
    {
        public Photo Adoptee { get; set; }

        public string GetImageUrl()
        {
            return Adoptee != null ? Adoptee.PictureNormalURL : string.Empty;
        }
    }
}
