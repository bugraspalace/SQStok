using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class BirimPozisyon
    {
        [Key]
        public int Id { get; set; }
        public int BirimID { get; set; }
        public Birim Birim { get; set; }

        public int PozisyonID { get; set; }
        public Pozisyon Pozisyon { get; set; }
    }
}
