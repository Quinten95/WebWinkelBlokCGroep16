using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

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
        public String ProductNaam { get; set; }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Ijsthee(int? aantalProducten)
        {
            
            if (aantalProducten.HasValue)
            {                
                this.AantalProducten = aantalProducten.Value;                
                return View("bestelFormulierIjsthee", this.AantalProducten);
            }
            return View();
            
        }
        
        public ActionResult Diksap(int? aantalProducten)
        {
            
               
            if (aantalProducten.HasValue)
            {
                this.AantalProducten = aantalProducten.Value;
                return View("bestelFormulierDiksap");
            }
            
            return View();
        }

        public ActionResult Vruchtensap(int? aantalProducten)
        {
            if (aantalProducten.HasValue)
            {
                this.AantalProducten = aantalProducten.Value;                
                return View("bestelFormulierVruchtensap");
            }
            return View();
        }

        public ActionResult Tomatensap(int? aantalProducten)
        {
            if (aantalProducten.HasValue)
            {
                this.AantalProducten = aantalProducten.Value;                
                return View("bestelFormulierTomatensap");
            }
            return View();
        }

        public ActionResult OverOns()
        {
            return View();
        }
   

        public ActionResult BestelFormulierIjsthee(String voornaam, String achternaam, String adres, String postcode, String telefoon, String email)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Adres = adres;
            this.Postcode = postcode;
            this.Telefoon = telefoon;
            this.Email = email;
            if (email != null)
            {
                ProductNaam = "IJsthee";
                SendMail();
                return View("bestellingGeslaagd");
            }
            return View();
        }
        public ActionResult BestelFormulierVruchtensap(String voornaam, String achternaam, String adres, String postcode, String telefoon, String email)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Adres = adres;
            this.Postcode = postcode;
            this.Telefoon = telefoon;
            this.Email = email;
            if (email != null)
            {
                ProductNaam = "Vruchtensap";
                SendMail();
                return View("bestellingGeslaagd");
            }
            return View();
        }
        public ActionResult BestelFormulierTomatensap(String voornaam, String achternaam, String adres, String postcode, String telefoon, String email)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Adres = adres;
            this.Postcode = postcode;
            this.Telefoon = telefoon;
            this.Email = email;
            if (email != null)
            {
                ProductNaam = "Tomatensap";
                SendMail();
                return View("bestellingGeslaagd");
            }
            return View();
        }
        public ActionResult BestelFormulierDiksap(String voornaam, String achternaam, String adres, String postcode, String telefoon, String email)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Adres = adres;
            this.Postcode = postcode;
            this.Telefoon = telefoon;
            this.Email = email;
            if (email != null)
            {
                ProductNaam = "Diksap";
                SendMail();
                return View("bestellingGeslaagd");
            }
            return View();
        }

        public void SendMail()
        {
            String adres = "suikervrijedrankjes.nl@gmail.com";
            String password = "12345Suikervrij";

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("suikervrijedrankjes.nl@gmail.com");
            msg.To.Add(new MailAddress("suikervrijedrankjes.nl@gmail.com"));
            msg.Subject = "Nieuwe bestelling";
            msg.Body ="Klantgegevens: naam: " + this.Voornaam + "\nachternaam: " + this.Achternaam + "\nadres: " + this.Adres + 
                      "\npostcode: " + this.Postcode + "\ntelefoonnr: " + this.Telefoon + "\ne-mail: " + this.Email + "\nProductnaam: " 
                      + this.ProductNaam + "\nAantal: " + this.AantalProducten;
            msg.IsBodyHtml = true;

            
            
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 25);
            
            NetworkCredential loginInfo = new NetworkCredential(adres, password);

            
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = loginInfo;
            
            smtpClient.Send(msg);
        }
    }
}
