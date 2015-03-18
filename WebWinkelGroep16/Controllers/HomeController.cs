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
            if (aantalProducten == 1)
            {
                this.Aantal = 1;
                return View("bestelFormulier", Aantal);
            }
            else if (aantalProducten == 2)
            {
                this.Aantal = 2;
                return View("bestelFormulier", Aantal);
            }
            else if (aantalProducten == 3)
            {
                this.Aantal = 3;
                return View("bestelFormulier", Aantal);
            }
            else if (aantalProducten == 4)
            {
                this.Aantal = 4;
                return View("bestelFormulier", Aantal);
            }
            else if (aantalProducten == 5)
            {
                this.Aantal = 5;
                return View("bestelFormulier", Aantal);
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

        public ActionResult BestelFormulier()
        {
            return View();
        }
    }
}
