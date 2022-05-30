using Microsoft.AspNetCore.Mvc;

namespace MvcModel.Controllers
{
    using Models; // Models namespacesi...
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            // Ödev =>
            // HaberBaslik, KisaText, Tarih (gunayyil) => uygun model tanımlanıyor. Controllerda haberler view'a bind ediliyor. View tarafı rzor ile oluşturuluyor ve Javascipt2 projesindeki client kodları cshtmle taşınıp içerisine razor syntax ile model yazdırılıyor...


            List<Ogrenci> ogrList = new List<Ogrenci>();
            ogrList.Add(new Ogrenci { Adi = "Ahmet", SoyAdi = "Kurt" });
            ogrList.Add(new Ogrenci { Adi = "Alper", SoyAdi = "Sonalp" });
            ogrList.Add(new Ogrenci { Adi = "Bilal", SoyAdi = "Ümit" });
            ogrList.Add(new Ogrenci { Adi = "Emre", SoyAdi = "Çakıral" });
            ogrList.Add(new Ogrenci { Adi = "Recep", SoyAdi = "" });

            return View(ogrList); // ViewResult //View'a ogrList'i model tipinde gönder...
        }


        public IActionResult Ogrencis()
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            ogrList.Add(new Ogrenci { Adi = "Ahmet", SoyAdi = "Kurt" });
            ogrList.Add(new Ogrenci { Adi = "Alper", SoyAdi = "Sonalp" });
            ogrList.Add(new Ogrenci { Adi = "Bilal", SoyAdi = "Ümit" });
            ogrList.Add(new Ogrenci { Adi = "Emre", SoyAdi = "Çakıral" });
            ogrList.Add(new Ogrenci { Adi = "Recep", SoyAdi = "" });

            return Json(ogrList); // JsonResult
        }
    }
}
