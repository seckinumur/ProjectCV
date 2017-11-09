using Entitiy.Context;
using Entitiy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ResetRepo
    {
        public static bool Sifirla()
        {
            try
            {
                using (PCDB db = new PCDB())
                {
                    try
                    {
                        var sil = db.Egitim.ToList();
                        db.Egitim.RemoveRange(sil);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Egitims', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }
                    try
                    {
                        var sil = db.ProjelerDeneyimler.ToList();
                        db.ProjelerDeneyimler.RemoveRange(sil);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.ProjelerDeneyimlers', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }
                    try
                    {
                        var sil = db.IsDeneyimleri.ToList();
                        db.IsDeneyimleri.RemoveRange(sil);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.IsDeneyimleris', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }
                    try
                    {
                        var sil = db.User.ToList();
                        db.User.RemoveRange(sil);
                        db.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('dbo.Users', RESEED, 0)");
                        db.SaveChanges();
                    }
                    catch { }

                    db.User.Add(new User
                    {
                        Admin = true,
                        AdSoyad = "Seçkin UMUR",
                        Beceriler = "ASP.NET MVC, C# Windows Form, HTML5, CSS3, Javascript, Bootsrap, JQuery, Arduino, Raspberry Pi, Microsoft Azure, MS SQL, CorelDraw, Adobe Photoshop, Adobe Illustrator",
                        DogumTarihi = "09.08.1985",
                        email = "seckinumur@gmail.com",
                        facebook = "https://www.facebook.com/seckinumur85",
                        github = "https://github.com/seckinumur",
                        linken = "https://tr.linkedin.com/in/seçkin-umur-710481104",
                        Sifre = "9916",
                        Meslek = "Software Developer & Web Developer",
                        Telefon = "+905423428009",
                        twitter = "https://twitter.com/SeckinUmur",
                        website = "https://www.seckinumur.com",
                        Diller = "İngilizce, C#, javaScript, HTML, CSS, SQL, Arduino(C)",
                        Resim = "/img/User/seckinumur.jpg"
                    });
                    db.SaveChanges();

                    db.Egitim.Add(new Egitim
                    {
                        OkulAdi = "Yamanevler İlkÖğretim Okulu",
                        Tanimi = "Orta Öğrenim",
                        Tarih = "1999",
                        YabanciDil = "İngilizce",
                        UserID = 1
                    });
                    db.SaveChanges();

                    db.Egitim.Add(new Egitim
                    {
                        OkulAdi = "Ümraniye Lisesi",
                        Tanimi = "Fen Lisesi",
                        Tarih = "2003",
                        YabanciDil = "İngilizce",
                        UserID = 1
                    });
                    db.SaveChanges();

                    db.Egitim.Add(new Egitim
                    {
                        OkulAdi = "Bilge Adam",
                        Tanimi = "Yazılım Uzmanı",
                        Tarih = "2017",
                        YabanciDil = "İngilizce",
                        UserID = 1
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "Project CV",
                        Tarih = "2017",
                        Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                        Aciklama = "MVC Teknolojisi Kullanarak Online CV Oluşturma Ve Görüntüleme Sistemi",
                        Link = "https://github.com/seckinumur/ProjectCV"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "Project Atlas",
                        Tarih = "2017",
                        Teknoloji = "C#, Windows Form, Entity Fremework, n-tier architecture",
                        Aciklama = "Windows Masaüstü Uygulaması Olarak Geliştirdiğim Bu Proje Google Map Sistemini Kullanıp Müşterilerin Adreslerini Kaydetme ve Hazırlanan Listeye Konuma Mahalleye Göre Navigasyon Hazırlama Gibi Daha Bir çok özellik İçermektedir.",
                        Link = "https://github.com/seckinumur/Project-Atlas"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "yardimciyayin.com",
                        Tarih = "2017",
                        Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                        Aciklama = "MVC E-Ticaret Uygulaması Olarak Geliştirildi, Stok Takip Cari ve Ürün Takip Sistemi olan Bir E ticaret Sitesi",
                        Link = "https://github.com/seckinumur/yardimciyayin"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "Project Hule",
                        Tarih = "2017",
                        Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                        Aciklama = "Almanya İstikbal ve Bellona Mağazalarına Online Satış Programı Olarak Geliştiriliyor. Bir çok Fonksiyonu Olacak Stok Takip, Ürün Takip, Cari Müşteri Yönetimi vb.. bir çok özellkik İçermektedir.",
                        Link = "https://github.com/seckinumur/ProjectHule"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "MarketMatik-Revize",
                        Tarih = "2016",
                        Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                        Aciklama = "2015 Yılında Geliştirdiğim Sonra .NET Versiyonunu Yükseltmek İçin Gözden Geçirdiğim Barkot Okuyuculu, Market Satış Ve Otomasyon Uygulamasıdır.",
                        Link = "https://github.com/seckinumur/MarketMatik-Revize"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "Choice Sosyal Hizmet Sistemi",
                        Tarih = "2016",
                        Teknoloji = "C#, Windows Form, Entity Fremework, n-tier, Sqlite",
                        Aciklama = "Bu Program TC. Aile Ve Sosyal Politikalar Bakanlığının Hizmetinde Çalışan Kurumlar İçin Evrak Otomasyon Ve kayıt sistemidir.",
                        Link = "https://github.com/seckinumur/ChoiceSosyalHizmet.Entity"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "VS2017YukleMatik",
                        Tarih = "2016",
                        Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                        Aciklama = "Visual Studio 2017 Ofline Yükleme Aracı (İlk Beta Versiyondan Beri Geliştirilmektedir. Son Versiyon mayıs 2017)",
                        Link = "https://github.com/seckinumur/VS2017YukleMatik"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "ArduinoConn",
                        Tarih = "2016",
                        Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                        Aciklama = "Bir Arduino İle Seri Port İle Haberleşerek Yakınlık Sensöründen Gelen Veriyi Hesaplayarak Müzik Sesini Artıran Veya Azaltan Bir Proje",
                        Link = "https://github.com/seckinumur/ArduinoConn"
                    });
                    db.SaveChanges();

                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        UserID = 1,
                        ProjeAdi = "MRCStok",
                        Tarih = "2015",
                        Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                        Aciklama = "Önceden Çalıştığım MRC Kahve Firmasına Geliştirdiğim Sqlite Veritabanlı Stok Takip Ürün Yönetim Otomasyonu. (2016 Yılında .NET VErsiyonu Yükselttim.)",
                        Link = "https://github.com/seckinumur/MRCStok"
                    });
                    db.SaveChanges();

                    db.IsDeneyimleri.Add(new IsDeneyimleri
                    {
                        Sirket = "Freelance",
                        Tarih = "2015-2017",
                        Aciklama = "2015 Yılından Beri C# Masaüstü Uygulamaları İle ASP.NET MVC Web Uygulamaları Geliştiriyorum.",
                        UserID = 1
                    });
                    db.SaveChanges();

                    db.IsDeneyimleri.Add(new IsDeneyimleri
                    {
                        Sirket = "MRC Kahve",
                        Tarih = "Ekim 2015 - Şubat 2017",
                        Aciklama = "İzmir'de MRC Kahve Firmasında Tasarımcı Grafiker Olarak Görev Aldım",
                        UserID = 1
                    });
                    db.SaveChanges();

                    db.IsDeneyimleri.Add(new IsDeneyimleri
                    {
                        Sirket = "WorkRoom",
                        Tarih = "2013 - Temmuz 2015",
                        Aciklama = "İstanbul'da Outdoor Reklam Tasarım Şirketinde Grafiker Olarak Görev Aldım",
                        UserID = 1
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
