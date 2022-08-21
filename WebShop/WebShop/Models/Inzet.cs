using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Inzet
    {
        [Key]
        public int InzetID { get; set; }
        public double Bedrag { get; set; }

        public Spel Spel { get; set; }
        public Klant Klant { get; set; }
    }
}
