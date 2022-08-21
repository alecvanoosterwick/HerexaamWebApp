using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Foto
    {
        [Key]
        public int FotoID { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public double Hoogte { get; set; }
        [Required]
        public double Breedte { get; set; }

        public ICollection<Product> Producten { get; set; }
    }
}
