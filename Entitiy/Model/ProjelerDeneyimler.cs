using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Model
{
   public class ProjelerDeneyimler
    {
        public int ProjelerDeneyimlerID { get; set; }
        public string ProjeAdi { get; set; }
        public string image { get; set; }
        public string Teknoloji { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
        public string Tarih { get; set; }
        public int User { get; set; }
    }
}
