using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "Nom")]
        public string Name { get; set; }

        [Required, Display(Name = "Adresse")]
        public string StreetAddress { get; set; }

        [Required, Display(Name = "Ville")]
        public string City { get; set; }

        [Required, Display(Name = "Pays")]
        public string State { get; set; }

        [Required, Display(Name = "Code Postal")]
        public string PostalCode { get; set; }

        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }

}
