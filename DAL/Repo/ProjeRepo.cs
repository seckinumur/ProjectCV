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
    public class ProjeRepo
    {
        public static bool Kaydet(VMProje data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    db.ProjelerDeneyimler.Add(new ProjelerDeneyimler
                    {
                        Aciklama = data.Aciklama,
                        Link = data.Link,
                        ProjeAdi = data.ProjeAdi,
                        Tarih = data.Tarih,
                        Teknoloji = data.Teknoloji,
                        UserID = data.UserID
                    });
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool Guncelle(VMProje data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var bul = db.ProjelerDeneyimler.FirstOrDefault(p => p.ProjelerDeneyimlerID == data.ProjelerDeneyimlerID);
                    bul.Link = data.Link;
                    bul.ProjeAdi = data.ProjeAdi;
                    bul.Tarih = data.Tarih;
                    bul.Teknoloji = data.Teknoloji;
                    bul.Aciklama = data.Aciklama;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool Sil(int ID)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var bul = db.ProjelerDeneyimler.FirstOrDefault(p => p.ProjelerDeneyimlerID == ID);
                    db.ProjelerDeneyimler.Remove(bul);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
