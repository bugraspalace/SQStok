using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Envanter
    {
        [Key]
        public int Id { get; set; }
        public int UrunID { get; set; }
        public Urun Urun { get; set; }
        public int Adet { get; set; }
    }
}
