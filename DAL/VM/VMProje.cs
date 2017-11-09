using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
   public class VMProje
    {
        public int ProjelerDeneyimlerID { get; set; }
        public string ProjeAdi { get; set; }
        public string Teknoloji { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
        public string Tarih { get; set; }
        public string Komut { get; set; }
        public int UserID { get; set; }
    }
}
