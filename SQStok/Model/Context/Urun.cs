using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQStok.Model.Context
{

    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }
        [Required]
        public string Barkod { get; set; }

        public string Aciklama { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka { get; set; }

        public int ModelId { get; set; }
        public Modeller Modeller { get; set; }

        public string Renk{ get; set; }

        public virtual ICollection<Fotograf> Fotograflar { get; set; } // Fotoğraflar koleksiyonu
    }

}
