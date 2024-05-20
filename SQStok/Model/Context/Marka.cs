using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQStok.Model.Context
{
    public class Marka
    {
        [Key]
        public int Id { get; set; }
        public string MarkaAd { get; set; }
    }
}
