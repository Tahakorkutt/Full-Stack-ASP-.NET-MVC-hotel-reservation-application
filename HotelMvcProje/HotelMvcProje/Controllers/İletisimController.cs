
using HotelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMvcProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        public ActionResult Index()
        {

            var bilgiler = db.Tblİletişim.ToList();
            return View(bilgiler);
        }
        [HttpGet]
        public PartialViewResult MesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MesajGonder(TblMesaj p)
        {
            db.TblMesajs.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
    
}