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
   public class LoginRepo
    {
        public static User Giris(VMLogin Data)
        {
            using(PCDB db = new PCDB())
            {
                try
                {
                    return db.User.FirstOrDefault(p => p.email == Data.email && p.Sifre == Data.Sifre);
                }
                catch
                {
                    return null;
                }
            }
        }
        public static User Kayit(VMLogin Data)
        {
            using (PCDB db = new PCDB())
            {
                try
                {
                    bool kontrol = db.User.Any(p => p.email == Data.email && p.Sifre == Data.Sifre);
                    if (kontrol == false)
                    {
                        db.User.Add(new User { AdSoyad = Data.AdSoyad, email = Data.email, Sifre = Data.Sifre });
                        db.SaveChanges();
                        return db.User.FirstOrDefault(p => p.email == Data.email && p.Sifre == Data.Sifre);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
