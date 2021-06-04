using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required, Display(Name = "Nom")]
        public string Name { get; set; }

        [Display(Name = "Adresse")]
        public string StreetAddress { get; set; }

        [Display(Name = "Ville")]
        public string City { get; set; }

        [Display(Name = "Pays")]
        public string State { get; set; }

        [Display(Name = "Code Postal")]
        public string PostalCode { get; set; }

        [Display(Name = "Tél ")]
        public string PhoneNumber { get; set; }

        public bool IsAuthorizedCompany { get; set; }
    }
}
