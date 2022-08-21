using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Klant
    {
        [Key]
        public int KlantID { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telefoonnummer { get; set; }
        [Required]
        public string Land { get; set; }
        [Required]
        public string Adres { get; set; }
        public double Munten { get; set; }
        [Required]
        public string WachtWoord { get; set; }

        public ICollection<Inzet> Inzetten { get; set; }
        public ICollection<Bestelling> Bestellingen { get; set; }
    }
}
