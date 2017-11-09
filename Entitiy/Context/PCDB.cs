namespace Entitiy.Context
{
    using Entitiy.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PCDB : DbContext
    {
        public PCDB()
            : base("name=PCDB")
        {
            Database.SetInitializer(new PCDBInitializer());
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<ProjelerDeneyimler> ProjelerDeneyimler { get; set; }
        public virtual DbSet<IsDeneyimleri> IsDeneyimleri { get; set; }
    }
    public class PCDBInitializer : CreateDatabaseIfNotExists<PCDB> //Otomatik database Oluþturma
    {
        protected override void Seed(PCDB db)
        {
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
                Diller = "Ýngilizce, C#, javaScript, HTML, CSS, SQL, Arduino(C)",
                Resim = "/img/User/seckinumur.jpg"
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Yamanevler ÝlkÖðretim Okulu",
                Tanimi = "Orta Öðrenim",
                Tarih = "1999",
                YabanciDil = "Ýngilizce",
                UserID=1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Ümraniye Lisesi",
                Tanimi = "Fen Lisesi",
                Tarih = "2003",
                YabanciDil = "Ýngilizce",
                UserID = 1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Bilge Adam",
                Tanimi = "Yazýlým Uzmaný",
                Tarih = "2017",
                YabanciDil = "Ýngilizce",
                UserID = 1
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project CV",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama = "MVC Teknolojisi Kullanarak Online CV Oluþturma Ve Görüntüleme Sistemi",
                Link= "https://github.com/seckinumur/ProjectCV"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project Atlas",
                Tarih = "2017",
                Teknoloji = "C#, Windows Form, Entity Fremework, n-tier architecture",
                Aciklama = "Windows Masaüstü Uygulamasý Olarak Geliþtirdiðim Bu Proje Google Map Sistemini Kullanýp Müþterilerin Adreslerini Kaydetme ve Hazýrlanan Listeye Konuma Mahalleye Göre Navigasyon Hazýrlama Gibi Daha Bir çok özellik Ýçermektedir.",
                Link = "https://github.com/seckinumur/Project-Atlas"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "yardimciyayin.com",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama="MVC E-Ticaret Uygulamasý Olarak Geliþtirildi, Stok Takip Cari ve Ürün Takip Sistemi olan Bir E ticaret Sitesi",
                Link = "https://github.com/seckinumur/yardimciyayin"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project Hule",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama = "Almanya Ýstikbal ve Bellona Maðazalarýna Online Satýþ Programý Olarak Geliþtiriliyor. Bir çok Fonksiyonu Olacak Stok Takip, Ürün Takip, Cari Müþteri Yönetimi vb.. bir çok özellkik Ýçermektedir.",
                Link = "https://github.com/seckinumur/ProjectHule"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "MarketMatik-Revize",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "2015 Yýlýnda Geliþtirdiðim Sonra .NET Versiyonunu Yükseltmek Ýçin Gözden Geçirdiðim Barkot Okuyuculu, Market Satýþ Ve Otomasyon Uygulamasýdýr.",
                Link = "https://github.com/seckinumur/MarketMatik-Revize"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Choice Sosyal Hizmet Sistemi",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, n-tier, Sqlite",
                Aciklama = "Bu Program TC. Aile Ve Sosyal Politikalar Bakanlýðýnýn Hizmetinde Çalýþan Kurumlar Ýçin Evrak Otomasyon Ve kayýt sistemidir.",
                Link = "https://github.com/seckinumur/ChoiceSosyalHizmet.Entity"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "VS2017YukleMatik",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "Visual Studio 2017 Ofline Yükleme Aracý (Ýlk Beta Versiyondan Beri Geliþtirilmektedir. Son Versiyon mayýs 2017)",
                Link = "https://github.com/seckinumur/VS2017YukleMatik"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "ArduinoConn",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "Bir Arduino Ýle Seri Port Ýle Haberleþerek Yakýnlýk Sensöründen Gelen Veriyi Hesaplayarak Müzik Sesini Artýran Veya Azaltan Bir Proje",
                Link = "https://github.com/seckinumur/ArduinoConn"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "MRCStok",
                Tarih = "2015",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "Önceden Çalýþtýðým MRC Kahve Firmasýna Geliþtirdiðim Sqlite Veritabanlý Stok Takip Ürün Yönetim Otomasyonu. (2016 Yýlýnda .NET VErsiyonu Yükselttim.)",
                Link = "https://github.com/seckinumur/MRCStok"
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "Freelance",
                Tarih = "2015-2017",
                Aciklama = "2015 Yýlýndan Beri C# Masaüstü Uygulamalarý Ýle ASP.NET MVC Web Uygulamalarý Geliþtiriyorum.",
                UserID = 1
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "MRC Kahve",
                Tarih = "Ekim 2015 - Þubat 2017",
                Aciklama = "Ýzmir'de MRC Kahve Firmasýnda Tasarýmcý Grafiker Olarak Görev Aldým",
                UserID = 1
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "WorkRoom",
                Tarih = "2013 - Temmuz 2015",
                Aciklama = "Ýstanbul'da Outdoor Reklam Tasarým Þirketinde Grafiker Olarak Görev Aldým",
                UserID = 1
            });
            db.SaveChanges();
        }
    }
}