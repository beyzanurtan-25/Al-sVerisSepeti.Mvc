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
    public class MusteriController : Controller
    {
        // GET: Admin/Musteri
        AlısverisContext ctx = new AlısverisContext();
        
        public ActionResult Index()

        {

            var musteriler= ctx.Musteriler.ToList();
            return View(musteriler);



        }

        public ActionResult MusteriEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkle(Musteri mst)
        {

            if (ModelState.IsValid)
            {
                ctx.Musteriler.Add(mst);


                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult MusteriGuncelle(int? id, Musteri mst)
        {

            var musteri = ctx.Musteriler.Find(id);

            if (ModelState.IsValid)
            {
                ctx.Musteriler.Add(mst);
            }
            return View(musteri);
        }
        [HttpPost]
        public ActionResult MusteriGuncelle(Musteri mst)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(mst).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult MusteriSil(int? id)
        {

            var mst = ctx.Musteriler.Find(id);
            ctx.Musteriler.Remove(mst);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}