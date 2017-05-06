using MarbleItalia.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MarbleItalia.Controllers
{
    public class MaterialsController : Controller
    {
        [Route("materials/marble-and-stone")]
        public ActionResult Marble()
        {
            return View();
        }

        [Route("materials/onyx-supplier")]
        public ActionResult Onyx()
        {
            return View();
        }
        [Route("materials/travertine-supplier")]
        public ActionResult Travertine()
        {
            return View();
        }

        [Route("materials/porphyry")]
        public ActionResult Porphyry()
        {
            return View();
        }

        //public ActionResult GenerateMaterials(string directory)
        //{
        //    string template = "<div class=\"col-sm-3 col-xs-6\"><div class=\"material\"><a class=\"materialGallery\" rel=\"material\" href=\"/Images/marble/{fileName}.jpg\" title=\"{Name}\"><img src=\"~/Images/marble/{fileName}.jpg\" /></a></div><p class=\"nameMaterial\">{Name}</p></div>";
        //    var items = System.IO.Directory.GetFiles(directory).ToList();
        //    string model = string.Empty;
        //    if (items != null && items.Any()) {
        //        foreach (var i in items) {
        //            string name = System.IO.Path.GetFileNameWithoutExtension(i);
        //            model = model + template.Replace("{fileName}", name).Replace("{Name}", name.Replace("-", " ").Replace("_", " ").ToLower());
        //        }
        //    }
        //    return Content(model);
        //}
    }
}