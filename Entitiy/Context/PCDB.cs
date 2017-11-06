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
    }
    public class PCDBInitializer : CreateDatabaseIfNotExists<PCDB> //Otomatik database Olu�turma
    {
        protected override void Seed(PCDB db)
        {
            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Yamanevler �lk��retim Okulu",
                Tanimi = "Orta ��renim",
                Tarih = "1999",
                YabanciDil = "�ngilizce",
                User=1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "�mraniye Lisesi",
                Tanimi = "Fen Lisesi",
                Tarih = "2003",
                YabanciDil = "�ngilizce",
                User=1
            });
            db.SaveChanges();

            db.Egitim.Add(new Egitim
            {
                OkulAdi = "Bilge Adam",
                Tanimi = "Yaz�l�m Uzman�",
                Tarih = "2017",
                YabanciDil = "�ngilizce",
                User=1
            });
            db.SaveChanges();

            db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
            {
                User = 1,
                ProjeAdi = "Project CV",
                Tarih = DateTime.Now.ToShortDateString(),
                Teknoloji = "ASP.NET MVC, C#, HTML5, CSS3, Bootstrap, Entity Fremework, JavaScript, n-tier architecture, JQuery",
                Aciklama = "MVC Teknolojisi Kullanarak Online CV Olu�turma Ve G�r�nt�leme Sistemi"
            });
            db.SaveChanges();

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
                YabanciDil = "�ngilizce",
                Egitimler = db.Egitim.Where(p => p.User == 1).ToList(),
                ProjelerDeneyimleri = db.ProjelerDeneyimler.Where(p => p.User == 1).ToList(),
            });
            db.SaveChanges();
        }
    }
}