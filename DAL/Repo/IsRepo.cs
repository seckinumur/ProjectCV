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
    public class IsRepo
    {
        public static bool Kaydet(VMIs data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    db.IsDeneyimleri.Add(new IsDeneyimleri
                    {
                        Aciklama = data.Aciklama,
                        Sirket = data.Sirket,
                        Tarih = data.Tarih,
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
        public static bool Guncelle(VMIs data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var bul = db.IsDeneyimleri.FirstOrDefault(p => p.IsDeneyimleriID == data.IsDeneyimleriID);
                    bul.Sirket = data.Sirket;
                    bul.Tarih = data.Tarih;
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
                    var bul = db.IsDeneyimleri.FirstOrDefault(p => p.IsDeneyimleriID == ID);
                    db.IsDeneyimleri.Remove(bul);
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
