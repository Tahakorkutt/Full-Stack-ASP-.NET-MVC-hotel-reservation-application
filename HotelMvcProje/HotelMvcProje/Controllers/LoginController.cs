using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HotelMvcProje.Models.Entity;



namespace HotelMvcProje.Controllers
{
    public class LoginController : Controller
    {
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblYeniKayit p)
        {
            var bilgiler = db.TblYeniKayits.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
                Session["Mail"] = bilgiler.Mail.ToString();
                return RedirectToAction("Index", "Misafir");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
     