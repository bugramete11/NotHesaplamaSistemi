# 🎓 Not Hesaplama ve Başarı Takip Sistemi

ASP.NET Core MVC mimarisiyle geliştirilmiş; vize, ödev ve final ağırlıklarını dinamik olarak hesaplayan, üniversite baraj kurallarını uygulayan duyarlı (responsive) bir web uygulamasıdır.

🔗 **SİTE:** [nothesaplamasistemi.runasp.net](https://nothesaplamasistemi.runasp.net)

---

## 📌 Proje Hakkında
Öğrencilerin dönem içi akademik başarılarını önceden simüle edebilmeleri ve dersten geçmek için finalden almaları gereken asgari notu takip edebilmeleri amacıyla tasarlanmıştır. Sunucu taraflı (server-side) doğrulama ve modern kullanıcı arayüzü prensiplerine uygun olarak kodlanmıştır.

---

## ✨ Temel Özellikler
* **Dinamik Ağırlık Hesaplama:** Vize, ödev ve final yüzdelerine göre ağırlıklı ortalama çıkarma.
* **Baraj Kontrolü (Business Logic):** Genel ortalama geçme notunun üzerinde olsa dahi finalden en az 50 alma şartı kontrolü.
* **Sonuç Geri Bildirimi:** Harf notu aralığı ve "Geçti / Kaldı" başarı durumunun renk kodlu gösterimi.
* **Modern & Duyarlı Tasarım:** Masaüstü ve mobil ekranlara tam uyumlu Dark Mode temalı arayüz.
* **HTTP Güvenliği:** Doğrudan GET/POST metod korumaları ve SSL (HTTPS) entegrasyonu.

---

## 🧮 Hesaplama Mantığı ve İş Kuralları

$$\text{Ortalama} = (\text{Vize} \times 0.30) + (\text{Ödev} \times 0.20) + (\text{Final} \times 0.50)$$

* **Geçme Koşulu 1:** $\text{Ortalama} \ge 50$
* **Geçme Koşulu 2 (Baraj):** $\text{Final} \ge 50$
> *Not: Final notu 50'nin altında kalan öğrenci, ortalaması 50 ve üzeri olsa dahi dersten "Kaldı" sayılır.*

---

## 🛠️ Kullanılan Teknolojiler
* **Backend:** C# / .NET 8 (ASP.NET Core MVC)
* **Frontend:** HTML5, CSS3 (Modern Dark Theme, Flexbox/Grid)
* **Yayınlama & Sunucu:** MonsterASP.NET (IIS / WebDeploy Altyapısı)
* **Versiyon Kontrol:** Git & GitHub

---

## 📌 Proje Hakkında
Öğrencilerin dönem içi akademik başarılarını önceden simüle edebilmeleri ve dersten geçmek için finalden almaları gereken asgari notu takip edebilmeleri amacıyla tasarlanmıştır. Sunucu taraflı (server-side) doğrulama ve modern kullanıcı arayüzü prensiplerine uygun olarak kodlanmıştır.

---

## ✨ Temel Özellikler
* **Dinamik Ağırlık Hesaplama:** Vize, ödev ve final yüzdelerine göre ağırlıklı ortalama çıkarma.
* **Baraj Kontrolü (Business Logic):** Genel ortalama geçme notunun üzerinde olsa dahi finalden en az 50 alma şartı kontrolü.
* **Sonuç Geri Bildirimi:** Harf notu aralığı ve "Geçti / Kaldı" başarı durumunun renk kodlu gösterimi.
* **Modern & Duyarlı Tasarım:** Masaüstü ve mobil ekranlara tam uyumlu Dark Mode temalı arayüz.
* **HTTP Güvenliği:** Doğrudan GET/POST metod korumaları ve SSL (HTTPS) entegrasyonu.

---

## 🧮 Hesaplama Mantığı ve İş Kuralları

$$\text{Ortalama} = (\text{Vize} \times 0.30) + (\text{Ödev} \times 0.20) + (\text{Final} \times 0.50)$$

* **Geçme Koşulu 1:** $\text{Ortalama} \ge 50$
* **Geçme Koşulu 2 (Baraj):** $\text{Final} \ge 50$
> *Not: Final notu 50'nin altında kalan öğrenci, ortalaması 50 ve üzeri olsa dahi dersten "Kaldı" sayılır.*

---

## 🛠️ Kullanılan Teknolojiler
* **Backend:** C# / .NET 8 (ASP.NET Core MVC)
* **Frontend:** HTML5, CSS3 (Modern Dark Theme, Flexbox/Grid)
* **Yayınlama & Sunucu:** MonsterASP.NET (IIS / WebDeploy Altyapısı)
* **Versiyon Kontrol:** Git & GitHub

---

## 💻 Yerel Kurulum (Local Setup)

Projeyi kendi bilgisayarınızda çalıştırmak için:

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/bugramete11/NotHesaplamaSistemi
