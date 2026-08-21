using Microsoft.AspNetCore.Mvc;
using System;

namespace NotHesaplamaSistemi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // HTML'den verileri alan TEK garsonumuz (Hesapla)
        [HttpPost]
        public IActionResult Hesapla(double vizeNotu, double vizeAgirligi, double odevNotu, double odevAgirligi, double finalNotu, double finalAgirligi, double gecmeNotu)
        {
            // 1. Ortalama Hesabý
            double ortalama = (vizeNotu * (vizeAgirligi / 100)) +
                              (odevNotu * (odevAgirligi / 100)) +
                              (finalNotu * (finalAgirligi / 100));

            ortalama = Math.Round(ortalama, 2);

            string durum = "";
            string mesaj = "";
            string cssRenk = "";

            // 2. Kurallar: Final 50 kanunu sabit, Geçme Notu kullanýcýdan geliyor.
            if (finalNotu < 50)
            {
                durum = "KALDI";
                mesaj = "Ortalamanýz yetse bile finalden minimum 50 alma zorunluluðunu saðlayamadýðýnýz için kaldýnýz.";
                cssRenk = "#e74c3c"; // Kýrmýzý
            }
            else if (ortalama < gecmeNotu)
            {
                durum = "KALDI";
                mesaj = $"Genel baþarý ortalamanýz okulunuzun geçme sýnýrý olan {gecmeNotu} puanýn altýnda kaldý.";
                cssRenk = "#e74c3c"; // Kýrmýzý
            }
            else
            {
                durum = "GEÇTÝ";
                mesaj = "Tebrikler, dersi baþarýyla geçtiniz!";
                cssRenk = "#27ae60"; // Yeþil
            }

            // 3. Sonuçlarý HTML'e Gönder
            ViewBag.Ortalama = ortalama;
            ViewBag.Durum = durum;
            ViewBag.Mesaj = mesaj;
            ViewBag.Renk = cssRenk;

            return View("Index");
        }
    }
}