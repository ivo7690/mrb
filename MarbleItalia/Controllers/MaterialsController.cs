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
        [Route("materials/marble")]
        public ActionResult Marble()
        {
            return View();
        }

        [Route("materials/onyx")]
        public ActionResult Onyx()
        {
            return View();
        }
        [Route("materials/travertine")]
        public ActionResult Travertine()
        {
            return View();
        }

        [Route("materials/porphyry")]
        public ActionResult Porphyry()
        {
            return View();
        }

    }
}