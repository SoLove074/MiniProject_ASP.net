using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspBeersProject;

namespace AspBeersProject.Controllers
{
    public class BeersController : Controller
    {
        private BeerEntities db = new BeerEntities();

        public ActionResult search(string SearchType, string SearchName, string SearchLo)
        {
            var TypeLst = new List<string>();
            var TypeQry = from d in db.Beers orderby d.Type select d.Type;
            TypeLst.AddRange(TypeQry.Distinct());
            ViewBag.SearchType = new SelectList(TypeLst);
            var LoLst = new List<string>();
            var LoQry = from d in db.Beers orderby d.Location select d.Location;
            LoLst.AddRange(LoQry.Distinct());
            ViewBag.SearchLo = new SelectList(LoLst);
            var Beers = from m in db.Beers select m;
            if (!string.IsNullOrEmpty(SearchName))
            {
                Beers = Beers.Where(s => s.Name.Contains(SearchName));
            }
            if (!string.IsNullOrEmpty(SearchType))
            {
                Beers = Beers.Where(x => x.Type == SearchType);
            }
            if (!string.IsNullOrEmpty(SearchLo))
            {
                Beers = Beers.Where(z => z.Location == SearchLo);
            }
            return View(Beers);
        }
        public ActionResult Index()
        {

            return View(db.Beers.ToList());

        }

        public ActionResult About()
        {
            ViewBag.Message = "JALEARNPORN TEAM ";

            return View();
        }


        public ActionResult LION_STOUT()
        {


            return View();
        }
        public ActionResult ALLAGASH_WHITE()
        {


            return View();
        }

        public ActionResult ARROGANT_BASTARD_ALE()
        {


            return View();
        }

        public ActionResult AVERY_HOG_HEAVEN()
        {


            return View();
        }

        public ActionResult BEAR_REPUBLIC_HOP_ROD_RYE()
        {


            return View();
        }

        public ActionResult BEAR_REPUBLIC_RED_ROCKET_ALE()
        {


            return View();
        }

        public ActionResult BELLS_HOPSLAM_ALE_MICHIGAN()
        {


            return View();
        }

        public ActionResult BELLS_SMITTEN_GOLDEN_RYE_ALE()
        {


            return View();
        }

        public ActionResult BREW_FREE_OR_DIE_IPA()
        {


            return View();
        }

        public ActionResult BROOKLYN_BLACK_OPS()
        {


            return View();
        }

        public ActionResult DALES_PALE_ALE()
        {


            return View();
        }

        public ActionResult DESCHUTES_BLACK_BUTTE_PORTER()
        {


            return View();
        }

        public ActionResult DESCHUTES_THE_ABYSS()
        {


            return View();
        }

        public ActionResult DUCK_RABBIT_BROWN_ALE()
        {


            return View();
        }

        public ActionResult DUCLAW_RETRIBUTION()
        {


            return View();
        }

        public ActionResult EDMUND_FITZGERALD()
        {


            return View();
        }

        public ActionResult EDWARD()
        {


            return View();
        }

        public ActionResult ELYSIANS_THE_GREAT_PUMPKIN()
        {


            return View();
        }

        public ActionResult FLYING_DOG_IN_HEAT_WHEAT()
        {


            return View();
        }

        public ActionResult FOUNDERS_BREAKFAST_STOUT()
        {


            return View();
        }

        public ActionResult FOUNDERS_KENTUCKY_BREAKFAST_STOUT()
        {


            return View();
        }

        public ActionResult FOUNDERS_REDS_RYE()
        {


            return View();
        }

        public ActionResult GNOMEGANG()
        {


            return View();
        }

        public ActionResult GOOSE_ISLAND_BOURBON_COUNTY_BRAND_COFFEE_STOUT()
        {


            return View();
        }

        public ActionResult GREEN_FLASH_HOP_HEAD_RED_ALE()
        {


            return View();
        }

        public ActionResult GUINNESS()
        {


            return View();
        }

        public ActionResult HOEGAARDEN()
        {


            return View();
        }

        public ActionResult JOHN_JOHN_DEAD_GUY_ALE()
        {


            return View();
        }

        public ActionResult KARL_STRAUSS_RED_TROLLEY_ALE()
        {


            return View();
        }

        public ActionResult KELLER_PILS()
        {


            return View();
        }

        public ActionResult LAGUNITAS_LIL_SUMPIN_SUMPIN_ALE()
        {


            return View();
        }

        public ActionResult LEFT_HAND_MILK_STOUT()
        {


            return View();
        }

        public ActionResult LOST_COAST_GREAT_WHITE()
        {


            return View();
        }

        public ActionResult NEWCASTLE_BROWN_ALE()
        {


            return View();
        }

        public ActionResult NINKASI_SPRING_REIGN()
        {


            return View();
        }

        public ActionResult PILSNER_URQUELL()
        {


            return View();
        }

        public ActionResult PIVO_HOPPY_PILS()
        {


            return View();
        }

        public ActionResult PLINY_THE_ELDER()
        {


            return View();
        }

        public ActionResult PUMKING()
        {


            return View();
        }

        public ActionResult ROGUE_HAZELNUT_BROWN_NECTAR()
        {


            return View();
        }

        public ActionResult SCHNEIDER_WEISSE()
        {


            return View();
        }

        public ActionResult SCRIMSHAW()
        {


            return View();
        }

        public ActionResult SCULPIN_IPA()
        {


            return View();
        }

        public ActionResult SIERRA_NEVADA()
        {


            return View();
        }

        public ActionResult SIXTY_MINUTE_DOGFISH()
        {


            return View();
        }

        public ActionResult ST_ARNOLD_AMBER()
        {


            return View();
        }

        public ActionResult THREE_FLOYDS_ZOMBIE_DUST()
        {


            return View();
        }

        public ActionResult TROEGS_NUGGET_NECTAR()
        {


            return View();
        }

        public ActionResult VICTORY_PRIMA_PILS()
        {


            return View();
        }

        public ActionResult WEIHENSTEPHANER_HEFEWEISSBIER()
        {


            return View();
        }

        public ActionResult WIDMER_HEFEWEIZEN()
        {


            return View();
        }
    }
}
