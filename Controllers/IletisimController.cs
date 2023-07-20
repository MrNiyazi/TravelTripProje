using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult IletisimYap()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult IletisimYap(iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return PartialView();
        }
    }
}