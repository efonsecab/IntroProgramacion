using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionAMSCognitiveServices.Models
{
    public class UserPhotos
    {
        public List<UserPhotoInfo> PhotosInfo { get; set; } = new List<UserPhotoInfo>();
    }

    public class UserPhotoInfo
    {
        public DateTime CreatedTime { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhotoLink { get; set; }
    }
}