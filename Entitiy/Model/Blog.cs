using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Model
{
   public class Blog
    {
        public int BlogID { get; set; }
        public string Tarih { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string image { get; set; }
        public string Konu { get; set; }
        public string Link { get; set; }
    }
}
