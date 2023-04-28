using HotelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMvcProje.Controllers
{
    
    public class RezervasyonController : Controller
    {
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();


        // GET: Rezervasyon
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        } 
       
        [HttpPost]
        public ActionResult Index(TblReservation p)
        {
            var misafirmail = (string)Session["Mail"];
            var misafirid = db.TblYeniKayits.Where(x => x.Mail ==
            misafirmail).Select(x => x.ID).FirstOrDefault();
            p.Durum = 15;
            p.Misafir = misafirid;
            db.TblReservations.Add(p);
            db.SaveChanges();
            return RedirectToAction("Rezervasyonlarim","Misafir");



        }
    }
}