using AlısVerisSepeti.Mvc.DAL;
using AlısVerisSepeti.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AlısVerisSepeti.Mvc.Areas.Admin.Controllers
{   [AllowAnonymous]
    public class GuvenlikController : Controller
    {
        // GET: Admin/Girsi
        AlısverisContext ctx = new AlısverisContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var kul = ctx.Kullanicilar.FirstOrDefault(x => x.kullaniciAd == kullanici.kullaniciAd && x.sifre == kullanici.sifre);
            if (kul != null)
            {
                FormsAuthentication.SetAuthCookie(kul.kullaniciAd, false);
                return RedirectToAction("Index", "Musteri");
            }
            else
            {
                return View("Index", "Musteri");

            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return View("Login");
        }
    }
}