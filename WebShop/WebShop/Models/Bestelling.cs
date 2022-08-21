using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Bestelling
    {
        public int BestellingID { get; set; }
        public int KlantId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Klant Klant { get; set; }
    }
}
