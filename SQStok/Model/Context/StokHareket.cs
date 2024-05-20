using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class StokHareket
    {
        [Key]
        public int Id{ get; set; }
        public DateTime Tarih { get; set; }
        public bool AlimSatim { get; set; }
        public int Miktar { get; set; }
        public int UrunID { get; set; }
        public Urun Urun { get; set; }
    }
}
