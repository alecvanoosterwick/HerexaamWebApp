using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Spel
    {
        [Key]
        public int SpelID { get; set; }
        [Required]
        public string Naam { get; set; }
        public double TotaleInzet { get; set; }
        [Required]
        public int Kleur { get; set; }
        public ICollection<Inzet> Inzetten { get; set; }
    }
}
