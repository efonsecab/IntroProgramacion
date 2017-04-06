using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroAMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Models.ContactInfo model = new Models.ContactInfo();
            model.Name = "Juan";
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Models.ContactInfo model)
        {
            if (ModelState.IsValid)
            {
                //poner acá código para agregar contact a la lista persistente
                return RedirectToAction(actionName: "Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}