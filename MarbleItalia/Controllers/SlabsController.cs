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
using System.IO;

namespace MarbleItalia.Controllers
{
    public class SlabsController : Controller
    {
        public class Slabs {
            public string Name { set; get; }
            public string DefaultImage { set; get; }
            public string BasePath { set; get; }
            public int Type { set; get; }
            public List<string> images { set; get; }
        }
        [Route("slabs-calacatta-marble-walls-and-floors")]
        public ActionResult Calacatta()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("calacatta");
            ViewBag.MaterialType = "Calacatta";
            return View(model);
        }

        [Route("slabs-statuario-marble-bathrooms-tiles")]
        public ActionResult Statuario()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("statuario");
            ViewBag.MaterialType = "Statuario";
            return View(model);
        }

        [Route("slabs-arabescato-marble-stone-flooring")]
        public ActionResult Arabescato()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("arabescato");
            ViewBag.MaterialType = "Arabescato";
            return View(model);
        }

        [Route("slabs-carrara-marble-kitchens-tiles")]
        public ActionResult Carrara()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("carrara");
            ViewBag.MaterialType = "Carrara";
            return View(model);
        }

        [Route("slabs-onyx-marble-book-matched-walls")]
        public ActionResult Onyx()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("onyx");
            ViewBag.MaterialType = "Onyx";
            return View(model);
        }

        [Route("slabs-available-marble-flooring")]
        public ActionResult AllAvailable()
        {
            List<Slabs> model = new List<Slabs>();
            model = GetStocksImages("all-slabs");
            ViewBag.MaterialType = "All slabs";
            return View(model);
        }

        public List<Slabs> GetStocksImages(string type)
        {
            List<Slabs> model = new List<Slabs>();
            if (Directory.Exists(Server.MapPath("/data/slabs/" + type)))
            {
                var stocks = Directory.GetDirectories(Server.MapPath("/data/slabs/" + type)).ToList();
                foreach (var stock in stocks)
                {
                    var items = Directory.GetFiles(stock).ToList();
                    string name = string.Empty;
                    if (items != null && items.Any())
                    {
                        name = Path.GetFileName(Path.GetDirectoryName(items.FirstOrDefault()));

                        items = items.Select(f => Path.GetFileName(f)).ToList();
                    }
                    string defaultImg = items.Where(i => i.ToLower().Contains("bookmatch")).FirstOrDefault();
                    if (string.IsNullOrEmpty(defaultImg))
                        defaultImg = items.FirstOrDefault();
                    model.Add(new Slabs
                    {
                        BasePath = "/data/slabs/" + type + "/",
                        Name = name,
                        images = items.OrderByDescending(i => i.ToLower().Contains("bookmatch")).ToList(),
                        DefaultImage = defaultImg
                    });
                }
            }
            return model;
        }
    }
}