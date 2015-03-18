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
        public int AantalProducten { get; set; }
        public String Voornaam { get; set; }
        public String Achternaam { get; set; }
        public String Adres { get; set; }
        public String Postcode { get; set; }
        public String Telefoon { get; set; }
        public String Email { get; set; } 

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Ijsthee(int? aantalProducten)
        {
            if (aantalProducten.HasValue)
            {
                this.AantalProducten = aantalProducten.Value;
                return View("bestelFormulierIjsthee");
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
   

        public ActionResult bestelFormulierIjsthee(String voornaam, String achternaam, String adres, String postcode, String telefoon, String email)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Adres = adres;
            this.Postcode = postcode;
            this.Telefoon = telefoon;
            this.Email = email;
            return View();
        }
    }
}
