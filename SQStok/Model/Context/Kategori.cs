using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public string KategoriAciklama { get; set; }
    }
}
