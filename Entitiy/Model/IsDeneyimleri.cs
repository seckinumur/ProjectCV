using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Model
{
    public class IsDeneyimleri
    {
        public int IsDeneyimleriID { get; set; }
        public string Sirket { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}
