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

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ijsthee()
        {
            return View();
        }
        
        public ActionResult diksap()
        {
            return View();
        }
        
        public ActionResult vruchtensap()
        {
            return View();
        }

        public ActionResult tomatensap()
        {
            return View();
        }

        public ActionResult overOns()
        {
            return View();
        }
    }
}
