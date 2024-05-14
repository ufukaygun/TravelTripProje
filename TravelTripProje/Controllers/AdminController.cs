using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context(); 
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();

            return View(degerler);
        }

        //İki tane aynı isimde  ActionResult tanımladık çünkü bunkların biri [Httpget] te çalışacak.YAni sayfa yüklendiğinde çalışacak.Sayfayı bize geri döndürecek
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        //Birşeyler yapıldığında burayı dööndür.
        //HAta vermemesi için Blog tan parametre çağırdık
        [HttpPost]
        public ActionResult YeniBlog(Blog p) 
        {
            c.Blogs.Add(p);
            c.SaveChanges();    
            //Index sayfasına yönlendir
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
    }
}