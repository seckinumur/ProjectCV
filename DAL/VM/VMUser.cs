using Entitiy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
    public class VMUser
    {
        public int UserID { get; set; }
        public string AdSoyad { get; set; }
        public string Meslek { get; set; }
        public string Beceriler { get; set; }
        public string DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string Diller { get; set; }
        public string Resim { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string github { get; set; }
        public string linken { get; set; }
        public string Sifre { get; set; }

        public  List<Egitim> Egitimler { get; set; }
        public  List<ProjelerDeneyimler> ProjelerDeneyimleri { get; set; }
        public  List<IsDeneyimleri> IsDeneyimleri { get; set; }
    }
}
