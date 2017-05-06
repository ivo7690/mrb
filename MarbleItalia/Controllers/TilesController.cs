using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarbleItalia.Controllers
{
    public class TilesController : Controller
    {
        public class CategoriesTiles
        {
            public string category { set; get; }
            public List<Tiles> tiles { set; get; }
        }
        public class Tiles
        {
            public string Name { set; get; }
            public string SrcImage { set; get; }
            public string BasePath { set; get; }
        }
        public class TilesViewModel
        {
            public List<CategoriesTiles> Tiles { set; get; }
            public string Title { set; get; }
            public string TypeMarble { set; get; }
            public string MetaTitle { set; get; }
            public string MetaDescription { set; get; }
            public string MetaKeywords { set; get; }
        }
        // GET: Tiles
        public ActionResult Index()
        {
            return View();
        }


        //[Route("tiles-{typeMarble}-marble")]
        //public ActionResult Master(string typeMarble)
        //{
        //    if (typeMarble == "allavailable") {
        //        ViewBag.Title = "All marble tiles";
        //        ViewBag.TypeMarble = "allavailable";
        //    } else { 
        //        ViewBag.Title = FirstCharacterCapitalize(typeMarble.ToLower()) + " marble tiles";
        //        ViewBag.TypeMarble = FirstCharacterCapitalize(typeMarble.ToLower());
        //    }
        //    var model = GetTilesImages(typeMarble.ToLower());
        //    return View(model);
        //}

        [Route("carrara-marble-tiles-stone-flooring")]
        public ActionResult Carrara()
        {
            var model = new TilesViewModel();
            model.Title = FirstCharacterCapitalize("carrara") + " marble tiles";
            model.TypeMarble = FirstCharacterCapitalize("carrara");

            model.Tiles = GetTilesImages("carrara");

            model.MetaTitle = "CARRARA BIANCO MARBLE TILES | STONE FLOORING";
            model.MetaDescription = "Carrara Bianco Marble Tiles. We manufacture and supply Tiles of different formats for stone flooring and walls coverings: bathrooms, kitchens.";
            model.MetaKeywords = "Carrara bianco, Carrara bianco marble, Carrara tiles, marble flooring, marble tiles, marble flooring tiles";

            return View("MasterCustom", model);
        }

        [Route("calacatta-marble-tiles-flooring")]
        public ActionResult Calacatta()
        {
            var model = new TilesViewModel();
            model.Title = FirstCharacterCapitalize("calacatta") + " marble tiles";
            model.TypeMarble = FirstCharacterCapitalize("calacatta");

            model.Tiles = GetTilesImages("calacatta");

            model.MetaTitle = "CALACATTA MARBLE TILES | MARBLE FLOORING";
            model.MetaDescription = "Calacatta Marble Tiles. We produce and supply Tiles of different sizes for marble flooring and walls coverings: bathrooms, kitchens, hallways, bedrooms.";
            model.MetaKeywords = "";

            return View("MasterCustom", model);
        }

        [Route("statuario-marble-tiles-bathrooms")]
        public ActionResult Statuario()
        {
            var model = new TilesViewModel();
            model.Title = FirstCharacterCapitalize("statuario") + " marble tiles";
            model.TypeMarble = FirstCharacterCapitalize("statuario");

            model.Tiles = GetTilesImages("statuario");

            model.MetaTitle = "STATUARIO MARBLE TILES | BATHROOMS  FLOORING";
            model.MetaDescription = "Statuario Marble Tiles. We manufacture and supply Tiles of different formats for marble flooring and covering walls: bathrooms, kitchens, hallways, bedrooms.";
            model.MetaKeywords = "";

            return View("MasterCustom", model);
        }


        [Route("arabescato-marble-tiles-kitchens")]
        public ActionResult Arabescato()
        {
            var model = new TilesViewModel();
            model.Title = FirstCharacterCapitalize("arabescato") + " marble tiles";
            model.TypeMarble = FirstCharacterCapitalize("arabescato");

            model.Tiles = GetTilesImages("arabescato");

            model.MetaTitle = "ARABESCATO MARBLE TILES | BATHROOMS & KITCHENS FLOORING";
            model.MetaDescription = "Arabescato Marble Tiles. We manufacture and supply Tiles of different formats for marble flooring and walls coverings: bathrooms, kitchens, hallways, bedrooms.";
            model.MetaKeywords = "";

            return View("MasterCustom", model);
        }


        [Route("marble-tiles-floors-walls")]
        public ActionResult AllTiles()
        {
            var model = new TilesViewModel();
            model.Title = FirstCharacterCapitalize("all") + " marble tiles";
            model.TypeMarble = FirstCharacterCapitalize("all");

            model.Tiles = GetTilesImages("all");

            model.MetaTitle = "MARBLE TILES | BATHROOMS & KITCHENS |  FLOORS & WALLS";
            model.MetaDescription = "Marble Tiles. We manufacture and supply Tiles of different formats for marble flooring and covering walls: bathrooms, kitchens, hallways, bedrooms.";
            model.MetaKeywords = "";

            return View("MasterCustom", model);
        }

        public static string FirstCharacterCapitalize(string s)
        {
            if (!string.IsNullOrEmpty(s) && s.Length > 1)
            {
                return char.ToUpper(s[0]) + s.Substring(1);
            }
            return s;
        }


        public List<CategoriesTiles> GetTilesImages(string type)
        {
            List<CategoriesTiles> model = new List<CategoriesTiles>();

            if (Directory.Exists(Server.MapPath("/data/tiles/" + type)))
            {
                var dirs = Directory.GetDirectories(Server.MapPath("/data/tiles/" + type)).ToList();
                foreach (var dir in dirs)
                {
                    string name = Path.GetFileName(dir);

                    var items = Directory.GetFiles(dir).ToList();
                    if (items != null && items.Any())
                    {
                        items = items.Select(f => Path.GetFileName(f)).ToList();

                        var _tiles = items.Select((f, index) => new Tiles
                        {
                            BasePath = "/data/tiles/" + type + "/" + name +"/",
                            Name = name + " "+ (index + 1),
                            SrcImage = Path.GetFileName(f)
                        }).ToList();

                        model.Add(new CategoriesTiles { category = name, tiles = _tiles });
                    }

                }

            }
            return model;
        }
    }
}