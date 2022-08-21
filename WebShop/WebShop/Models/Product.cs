using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public double Prijs { get; set; }
        [Required]
        public string Float { get; set; }
        [Required]
        public string Slijtage { get; set; }
        [Required]
        public Foto Foto { get; set; }

        public ICollection<Bestelling> Bestelling { get; set; }
    }
}
