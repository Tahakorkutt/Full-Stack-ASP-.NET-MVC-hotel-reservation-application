using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HotelMvcProje.Models.Entity;

namespace HotelMvcProje.Controllers
{
    [Authorize]
    public class MisafirController : Controller
    {


        // GET: Misafir
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        public ActionResult Index()
        {
            var misafirmail = (string)Session["Mail"];
            var misafirbilgi = db.TblYeniKayits.Where(x => x.Mail == misafirmail).FirstOrDefault();
            return View(misafirbilgi);
        }
    
        public ActionResult Rezervasyonlarim()
        {
            var misafirmail = (string)Session["Mail"];
            ViewBag.a = misafirmail;

            var degerler = db.TblReservations.Where(x => x.Misafir == 1).ToList();
            return View(degerler);
        }
        public ActionResult MisafirBilgiGuncelle(TblYeniKayit p)
        {
            var misafir = db.TblYeniKayits.Find(p.ID);
            misafir.AdSoyad = p.AdSoyad;
            misafir.Sifre = p.Sifre;
            misafir.Telefon = p.Telefon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GelenMesajlar()
        {
            var misafirmail = (string)Session["Mail"];
            var mesajlar = db.TblMesaj2.Where(x => x.Alici == misafirmail).ToList();
            return View(mesajlar);

           
        } public ActionResult GidenMesajlar()
        {
            var misafirmail = (string)Session["Mail"];
            var mesajlar = db.TblMesaj2.Where(x => x.Gonderen == misafirmail).ToList();
            return View(mesajlar);

           
        }
        public ActionResult MesajDetay(int id)
        {
            var mesaj = db.TblMesaj2.Where(x => x.MesajID == id).FirstOrDefault();
            return View(mesaj);
        }
        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMesaj(TblMesaj2 p)
        {
            var misafirmail = (string)Session["Mail"];
            p.Gonderen = misafirmail;
            p.Alici = "Admin";
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblMesaj2.Add(p);
            db.SaveChanges();
            return RedirectToAction("GidenMesajlar");
        }
    }
    
}
     