using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Model
{
    public class Egitim
    {
        public int EgitimID { get; set; }
        public string OkulAdi { get; set; }
        public string Tarih { get; set; }
        public string Tanimi { get; set; }
        public string YabanciDil { get; set; }
        public int User { get; set; }
    }
}
