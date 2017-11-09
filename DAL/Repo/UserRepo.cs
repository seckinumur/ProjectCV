using DAL.VM;
using Entitiy.Context;
using Entitiy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo
    {
        public static User KaydetGuncelle(VMUser Data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var bul = db.User.FirstOrDefault(p => p.UserID == Data.UserID);
                    bul.AdSoyad = Data.AdSoyad;
                    bul.Beceriler = Data.Beceriler;
                    bul.DogumTarihi = Data.DogumTarihi;
                    bul.email = Data.email;
                    bul.facebook = Data.facebook;
                    bul.github = Data.github;
                    bul.linken = Data.linken;
                    bul.Meslek = Data.Meslek;
                    bul.Resim = Data.Resim;
                    bul.Sifre = Data.Sifre;
                    bul.Telefon = Data.Telefon;
                    bul.twitter = Data.twitter;
                    bul.website = Data.website;
                    bul.Diller = Data.Diller;
                    db.SaveChanges();
                    return db.User.FirstOrDefault(p => p.UserID == Data.UserID);
                }
                catch
                {
                    return null;
                }
            }
        }
        public static User KullaniciBul(string ID)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    int id = int.Parse(ID);
                    return db.User.FirstOrDefault(p => p.UserID == id);
                }
                catch
                {
                    return null;
                }
            }
        }
        public static VMUser UserFindView()
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var egitim = db.Egitim.Where(p => p.UserID == 1).ToList();
                    var projeler = db.ProjelerDeneyimler.Where(p => p.UserID == 1).ToList();
                    var isdeneyim = db.IsDeneyimleri.Where(p => p.UserID == 1).ToList();
                    var o = db.User.FirstOrDefault(p => p.UserID == 1);
                    VMUser gonder = new VMUser
                    {
                        AdSoyad=o.AdSoyad,
                        Beceriler=o.Beceriler,
                        Diller=o.Diller,
                        DogumTarihi=o.DogumTarihi,
                        Egitimler=egitim,
                        email=o.email,
                        facebook=o.facebook,
                        github=o.github,
                        linken=o.linken,
                        Meslek=o.Meslek,
                        ProjelerDeneyimleri=projeler,
                        Resim=o.Resim,
                        Sifre=o.Sifre,
                        Telefon=o.Telefon,
                        twitter=o.twitter,
                        website=o.website,
                        UserID=o.UserID,
                        IsDeneyimleri=isdeneyim
                    };
                    return gonder;
                }
                catch
                {
                    return null;
                }
            }
        }
        public static VMUser UserFindViewID(string id)
        {
            int ID = int.Parse(id);
            using (PCDB db = new PCDB())
            {
                try
                {
                    var egitim = db.Egitim.Where(p => p.UserID == ID).ToList();
                    var projeler = db.ProjelerDeneyimler.Where(p => p.UserID == ID).ToList();
                    var isdeneyim = db.IsDeneyimleri.Where(p => p.UserID == ID).ToList();
                    var o = db.User.FirstOrDefault(p => p.UserID == ID);
                    VMUser gonder = new VMUser
                    {
                        AdSoyad = o.AdSoyad,
                        Beceriler = o.Beceriler,
                        Diller = o.Diller,
                        DogumTarihi = o.DogumTarihi,
                        Egitimler = egitim,
                        email = o.email,
                        facebook = o.facebook,
                        github = o.github,
                        linken = o.linken,
                        Meslek = o.Meslek,
                        ProjelerDeneyimleri = projeler,
                        Resim = o.Resim,
                        Sifre = o.Sifre,
                        Telefon = o.Telefon,
                        twitter = o.twitter,
                        website = o.website,
                        UserID = o.UserID,
                        IsDeneyimleri = isdeneyim
                    };
                    return gonder;
                }
                catch
                {
                    return null;
                }
            }
        }
        public static VMUser UserFindCV(int ID)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var egitim = db.Egitim.Where(p => p.UserID == ID).ToList();
                    var projeler = db.ProjelerDeneyimler.Where(p => p.UserID == ID).ToList();
                    var isdeneyim = db.IsDeneyimleri.Where(p => p.UserID == ID).ToList();
                    var o = db.User.FirstOrDefault(p => p.UserID == ID);
                    VMUser gonder = new VMUser
                    {
                        AdSoyad = o.AdSoyad,
                        Beceriler = o.Beceriler,
                        Diller = o.Diller,
                        DogumTarihi = o.DogumTarihi,
                        Egitimler = egitim,
                        email = o.email,
                        facebook = o.facebook,
                        github = o.github,
                        linken = o.linken,
                        Meslek = o.Meslek,
                        ProjelerDeneyimleri = projeler,
                        Resim = o.Resim,
                        Sifre = o.Sifre,
                        Telefon = o.Telefon,
                        twitter = o.twitter,
                        website = o.website,
                        UserID = o.UserID,
                        IsDeneyimleri = isdeneyim
                    };
                    return gonder;
                }
                catch
                {
                    return null;
                }
            }
        }
        public static bool AdminKontrol(string Id)
        {
            int ID = int.Parse(Id);
            using (PCDB db = new PCDB())
            {
                return db.User.Any(p => p.UserID == ID && p.Admin == true);
            }
        }
    }
}
