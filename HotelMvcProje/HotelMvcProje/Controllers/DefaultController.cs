
using HotelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMvcProje.Controllers
{
    public class DefaultController : Controller
    {
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();


        public ActionResult Hakkimda()
        {
            var veriler = db.TblHakkimdas.ToList();
            return View(veriler);
        }
        
       
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}