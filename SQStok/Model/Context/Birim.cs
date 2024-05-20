using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Birim
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
