using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class MarkaKategori
    {
        public int Id { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
    }
}
