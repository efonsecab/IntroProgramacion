using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionAMSCognitiveServices.Controllers
{
    [Authorize]
    public class CognitiveServicesController : Controller
    {
        // GET: CognitiveServices
        public ActionResult AnalyzeImage(string imageId)
        {
            Facebook.FacebookClient objFBClient = new Facebook.FacebookClient(GlobalSettings.Facebook_AccessToken);
            dynamic currentPhotoInfo = objFBClient.Get(string.Format("{0}?fields=link,images", imageId));
            var linkToFirstImage = currentPhotoInfo.images[0].source;
            System.Net.WebClient webClient = new System.Net.WebClient();
            //byte[] photoBytes = webClient.DownloadData(linkToFirstImage);
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey-ComputerVision"];
            string requestUrl = "https://westus.api.cognitive.microsoft.com/vision/v1.0/analyze?language=en&visualFeatures={0}&details={1}";
            requestUrl = string.Format(requestUrl, "Categories,Tags,Description,Faces,ImageType,Color,Adult", "Celebrities");
            System.Net.WebRequest request = System.Net.WebRequest.Create(requestUrl);
            request.ContentType = "application/json";
            //request.Headers.Add("visualFeatures", "Categories,Tags,Description,Faces,ImageType,Color,Adult");
            //request.Headers.Add("details", "Celebrities");
            request.Headers.Add("Ocp-Apim-Subscription-Key", apiKey);
            request.Method = "Post";
            string bodyContent = "{\"url\":\"{0}\"}";
            bodyContent = bodyContent.Replace("{0}", linkToFirstImage);
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(request.GetRequestStream()))
            {
                writer.Write(bodyContent);
                writer.Close();
            }
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            Models.APIs.ComputerVision.CompputerVisionInfo model = null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(responseStream))
            {
                string returnedContent = reader.ReadToEnd();
                model = Newtonsoft.Json.JsonConvert.DeserializeObject<
                    Models.APIs.ComputerVision.CompputerVisionInfo>(returnedContent);
                model.ImageUrl = linkToFirstImage;
                reader.Close();
            }
            return View(model);
        }
    }
};