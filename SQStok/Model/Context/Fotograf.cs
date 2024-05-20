using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Fotograf
    {
        public int ID { get; set; }
        public string DosyaAdi { get; set; }
        public byte[] FotografVeri { get; set; }
        public int UrunID { get; set; } // Bir fotoğrafın hangi ürüne ait olduğunu belirtmek için
        public virtual Urun Urun { get; set; } // İlişkiyi belirtmek için
    }
}
