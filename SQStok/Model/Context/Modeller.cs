using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Modeller
    {
        [Key]
        public int Id { get; set; }
        public string ModelAd { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
