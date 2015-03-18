using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWinkelGroep16.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public int Aantal { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Ijsthee(int? aantalProducten)
        {
            if (aantalProducten.HasValue)
            {
                this.Aantal = aantalProducten.Value;
                return View("bestelFormulierIjsthee", Aantal);
            }
            return View();
            
        }
        
        public ActionResult Diksap()
        {
            return View();
        }
        
        public ActionResult Vruchtensap()
        {
            return View();
        }

        public ActionResult Tomatensap()
        {
            return View();
        }

        public ActionResult OverOns()
        {
            return View();
        }
    }
}
