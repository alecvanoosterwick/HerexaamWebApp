using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebShop.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebShopUser class
    public class WebShopUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string PostalCode { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Country { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Adress { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string MobileNumber { get; set; }
        
    }
}
