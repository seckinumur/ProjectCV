using DAL.VM;
using Entitiy.Model;
using Entitiy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class EgitimRepo
    {
        public static bool Kaydet(VMEgitim data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    db.Egitim.Add(new Egitim
                    {
                        OkulAdi= data.OkulAdi,
                        Tanimi=data.Tanimi,
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
        public static bool Guncelle(VMEgitim data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    var bul = db.Egitim.FirstOrDefault(p => p.EgitimID == data.EgitimID);
                    bul.OkulAdi = data.OkulAdi;
                    bul.Tarih = data.Tarih;
                    bul.Tanimi = data.Tanimi;
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
                    var bul = db.Egitim.FirstOrDefault(p => p.EgitimID == ID);
                    db.Egitim.Remove(bul);
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
