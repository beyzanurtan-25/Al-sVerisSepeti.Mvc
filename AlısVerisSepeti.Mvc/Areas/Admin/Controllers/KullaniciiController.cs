using AlısVerisSepeti.Mvc.DAL;
using AlısVerisSepeti.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlısVerisSepeti.Mvc.Areas.Admin.Controllers
{   [AllowAnonymous]
    public class KullaniciiController : Controller
    {
        AlısverisContext ctx = new AlısverisContext();
        // GET: Admin/Kullanicii
        public ActionResult Uyelik()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Uyelik(Kullanici klc)
        {
            if (ModelState.IsValid)
            {
                ctx.Kullanicilar.Add(klc);
            }

            int sonuc = ctx.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Login", "Guvenlik");
            }
            return View();
        }
    }
}