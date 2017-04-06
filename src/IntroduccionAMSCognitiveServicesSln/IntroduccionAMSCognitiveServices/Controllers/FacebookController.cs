using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionAMSCognitiveServices.Controllers
{
    public class FacebookController : Controller
    {
        // GET: Facebook
        public ActionResult ListMyPhotos()
        {
            Models.UserPhotos objUserPhotos = new Models.UserPhotos();
            Facebook.FacebookClient objFBClient =
                new Facebook.FacebookClient(GlobalSettings.Facebook_AccessToken);
            dynamic myPhotos=objFBClient.Get("/me/photos");
            if (myPhotos.data.Count > 0)
            {
                for (int iPos = 0; iPos < myPhotos.data.Count; iPos++)
                {
                    var currentRow = myPhotos.data[iPos];
                    Models.UserPhotoInfo objUserPhotoInfo = new Models.UserPhotoInfo();
                    objUserPhotoInfo.CreatedTime = DateTime.Parse(currentRow.created_time);
                    objUserPhotoInfo.Name = currentRow.name;
                    objUserPhotoInfo.Id = currentRow.id;
                    dynamic currentPhotoInfo = objFBClient.Get(string.Format("{0}?fields=link,images", objUserPhotoInfo.Id));
                    var linkToFirstImage = currentPhotoInfo.images[0].source;

                    //objUserPhotoInfo.PhotoLink = currentPhotoInfo.link;
                    objUserPhotoInfo.PhotoLink = linkToFirstImage;
                    objUserPhotos.PhotosInfo.Add(objUserPhotoInfo);
                }
            }
            return View(objUserPhotos);
        }
    }
}