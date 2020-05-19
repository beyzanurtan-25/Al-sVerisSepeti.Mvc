using AlısVerisSepeti.Mvc.DAL;
using AlısVerisSepeti.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlısVerisSepeti.Mvc.Areas.Admin.Controllers
{
    public class UrunController : Controller
    {
        // GET: Admin/Urun
        AlısverisContext ctx = new AlısverisContext();

        public ActionResult Index()

        {

            var urunler = ctx.Urunler.ToList();
            return View(urunler);



        }

        public ActionResult UrunEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun urn)
        {

            if (ModelState.IsValid)
            {
                ctx.Urunler.Add(urn);


                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult UrunGuncelle(int? id, Urun urn)
        {

            var urun = ctx.Urunler.Find(id);

            if (ModelState.IsValid)
            {
                ctx.Urunler.Add(urn);
            }
            return View(urun);
        }
        [HttpPost]
        public ActionResult UrunGuncelle(Urun urn)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(urn).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult UrunSil(int? id)
        {

            var urn = ctx.Urunler.Find(id);
            ctx.Urunler.Remove(urn);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}