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
    public class PCDBInitializer : CreateDatabaseIfNotExists<PCDB> //Otomatik database Olu�turma
    {
        protected override void Seed(PCDB db)
        {
            db.User.Add(new User
            {
                Admin = true,
                AdSoyad = "Se�kin UMUR",
                Beceriler = "ASP.NET MVC, C# Windows Form, HTML5, CSS3, Javascript, Bootsrap, JQuery, Arduino, Raspberry Pi, Microsoft Azure, MS SQL, CorelDraw, Adobe Photoshop, Adobe Illustrator",
                DogumTarihi = "09.08.1985",
                email = "seckinumur@gmail.com",
                facebook = "https://www.facebook.com/seckinumur85",
                github = "https://github.com/seckinumur",
                linken = "https://tr.linkedin.com/in/se�kin-umur-710481104",
                Sifre = "9916",
                Meslek = "Software Developer & Web Developer",
                Telefon = "+905423428009",
                twitter = "https://twitter.com/SeckinUmur",
                website = "https://www.seckinumur.com",
                Diller = "�ngilizce, C#, javaScript, HTML, CSS, SQL, Arduino(C)",
                Resim = "/img/User/seckinumur.jpg"
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Yamanevler �lk��retim Okulu",
                Tanimi = "Orta ��renim",
                Tarih = "1999",
                YabanciDil = "�ngilizce",
                UserID=1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "�mraniye Lisesi",
                Tanimi = "Fen Lisesi",
                Tarih = "2003",
                YabanciDil = "�ngilizce",
                UserID = 1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Bilge Adam",
                Tanimi = "Yaz�l�m Uzman�",
                Tarih = "2017",
                YabanciDil = "�ngilizce",
                UserID = 1
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project CV",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama = "MVC Teknolojisi Kullanarak Online CV Olu�turma Ve G�r�nt�leme Sistemi",
                Link= "https://github.com/seckinumur/ProjectCV"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project Atlas",
                Tarih = "2017",
                Teknoloji = "C#, Windows Form, Entity Fremework, n-tier architecture",
                Aciklama = "Windows Masa�st� Uygulamas� Olarak Geli�tirdi�im Bu Proje Google Map Sistemini Kullan�p M��terilerin Adreslerini Kaydetme ve Haz�rlanan Listeye Konuma Mahalleye G�re Navigasyon Haz�rlama Gibi Daha Bir �ok �zellik ��ermektedir.",
                Link = "https://github.com/seckinumur/Project-Atlas"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "yardimciyayin.com",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama="MVC E-Ticaret Uygulamas� Olarak Geli�tirildi, Stok Takip Cari ve �r�n Takip Sistemi olan Bir E ticaret Sitesi",
                Link = "https://github.com/seckinumur/yardimciyayin"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Project Hule",
                Tarih = "2017",
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama = "Almanya �stikbal ve Bellona Ma�azalar�na Online Sat�� Program� Olarak Geli�tiriliyor. Bir �ok Fonksiyonu Olacak Stok Takip, �r�n Takip, Cari M��teri Y�netimi vb.. bir �ok �zellkik ��ermektedir.",
                Link = "https://github.com/seckinumur/ProjectHule"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "MarketMatik-Revize",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "2015 Y�l�nda Geli�tirdi�im Sonra .NET Versiyonunu Y�kseltmek ��in G�zden Ge�irdi�im Barkot Okuyuculu, Market Sat�� Ve Otomasyon Uygulamas�d�r.",
                Link = "https://github.com/seckinumur/MarketMatik-Revize"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "Choice Sosyal Hizmet Sistemi",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, n-tier, Sqlite",
                Aciklama = "Bu Program TC. Aile Ve Sosyal Politikalar Bakanl���n�n Hizmetinde �al��an Kurumlar ��in Evrak Otomasyon Ve kay�t sistemidir.",
                Link = "https://github.com/seckinumur/ChoiceSosyalHizmet.Entity"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "VS2017YukleMatik",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "Visual Studio 2017 Ofline Y�kleme Arac� (�lk Beta Versiyondan Beri Geli�tirilmektedir. Son Versiyon may�s 2017)",
                Link = "https://github.com/seckinumur/VS2017YukleMatik"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "ArduinoConn",
                Tarih = "2016",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "Bir Arduino �le Seri Port �le Haberle�erek Yak�nl�k Sens�r�nden Gelen Veriyi Hesaplayarak M�zik Sesini Art�ran Veya Azaltan Bir Proje",
                Link = "https://github.com/seckinumur/ArduinoConn"
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                UserID = 1,
                ProjeAdi = "MRCStok",
                Tarih = "2015",
                Teknoloji = "C#, Windows Form, Entity Fremework, Sqlite",
                Aciklama = "�nceden �al��t���m MRC Kahve Firmas�na Geli�tirdi�im Sqlite Veritabanl� Stok Takip �r�n Y�netim Otomasyonu. (2016 Y�l�nda .NET VErsiyonu Y�kselttim.)",
                Link = "https://github.com/seckinumur/MRCStok"
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "Freelance",
                Tarih = "2015-2017",
                Aciklama = "2015 Y�l�ndan Beri C# Masa�st� Uygulamalar� �le ASP.NET MVC Web Uygulamalar� Geli�tiriyorum.",
                UserID = 1
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "MRC Kahve",
                Tarih = "Ekim 2015 - �ubat 2017",
                Aciklama = "�zmir'de MRC Kahve Firmas�nda Tasar�mc� Grafiker Olarak G�rev Ald�m",
                UserID = 1
            });
            db.SaveChanges();

            db.IsDeneyimleri.Add(new IsDeneyimleri
            {
                Sirket = "WorkRoom",
                Tarih = "2013 - Temmuz 2015",
                Aciklama = "�stanbul'da Outdoor Reklam Tasar�m �irketinde Grafiker Olarak G�rev Ald�m",
                UserID = 1
            });
            db.SaveChanges();
        }
    }
}