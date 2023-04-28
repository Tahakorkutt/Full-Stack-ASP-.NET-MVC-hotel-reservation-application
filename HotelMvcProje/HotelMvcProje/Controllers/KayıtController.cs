using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelMvcProje.Models.Entity;

namespace HotelMvcProje.Controllers
{
    public class KayıtController : Controller
    {
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        // GET: Kayıt
        public ActionResult KayıtOl()
        {
            return View();
        }
        public ActionResult KayitOl(TblYeniKayit p)
        {
            db.TblYeniKayits.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}