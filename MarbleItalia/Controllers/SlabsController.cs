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
    public class SlabsController : Controller
    {
        [Route("slabs-calacatta-marble")]
        public ActionResult Calacatta()
        {
            return View();
        }

        [Route("slabs-statuario-marble")]
        public ActionResult Statuario()
        {
            return View();
        }

        [Route("slabs-arabescato-marble")]
        public ActionResult Arabescato()
        {
            return View();
        }

        [Route("slabs-carrara-marble")]
        public ActionResult Carrara()
        {
            return View();
        }

        [Route("slabs-onyx-marble")]
        public ActionResult Onyx()
        {
            return View();
        }

        [Route("slabs-available")]
        public ActionResult AllAvailable()
        {
            return View();
        }

    }
}