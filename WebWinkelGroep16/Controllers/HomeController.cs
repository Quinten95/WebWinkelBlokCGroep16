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
                SendMail();
            }
            return View();
        }

        public void SendMail()
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(this.Email);
            msg.To.Add(new MailAddress("quinten103@gmail.com"));
            msg.Subject = "Nieuwe bestelling";
            msg.Body = this.Voornaam + "\n" + this.Achternaam + "\n" + this.Adres + "\n" + this.Postcode + "\n" + this.Telefoon + "\n" + this.Email +
                "\nAantal: " + this.AantalProducten.ToString();
            msg.IsBodyHtml = true;
            
            String adres = "suikervrijedrankjes.nl@gmail.com";
            String password = "123456Suikervrij";
            
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            
            NetworkCredential loginInfo = new NetworkCredential(adres, password);
            
           
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = loginInfo;
            
            smtpClient.Send(msg); 
        }
    }
}
