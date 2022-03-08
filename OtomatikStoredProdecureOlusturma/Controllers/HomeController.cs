using OtomatikStoredProdecureOlusturma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomatikStoredProdecureOlusturma.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            db.Kitaplar.ToList();

            Kitap k = new Kitap() { KitapAd = "sefiller", Aciklama = "Sefil Hayatlar", YayinTarihi = DateTime.Now };
            db.Kitaplar.Add(k);
            db.SaveChanges();
            
            return View();
        }
    }
}