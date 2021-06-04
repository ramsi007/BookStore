using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required, Display(Name = "Date")]
        public DateTime OrderDate { get; set; }

        [Required, Display(Name= "Date d'expédition")]
        public DateTime ShippingDate { get; set; }

        [Required, Display(Name = "Total")]
        public Double OrderTotal { get; set; }

        [Display(Name = "Numéro de suivi")]
        public string TrackingNumber { get; set; }


        public string Carrier { get; set; }

        [Display(Name = "Status")]
        public string OrderStatus { get; set; }

        [Display(Name = "Status de paiment")]
        public string PaymentStatus { get; set; }

        [Display(Name = "Date de paiment")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Date limite de paiement")]
        public DateTime PaymentDueDate { get; set; }


        public string TransactionId { get; set; }

        [Required, Display(Name = "Contact")]
        public string PhoneNumber { get; set; }

        [Required, Display(Name = "Adresse")]
        public string StreetAddress { get; set; }

        [Required, Display(Name = "Ville")]
        public string City { get; set; }

        [Required, Display(Name = "Pays")]
        public string State { get; set; }

        [Required, Display(Name = "Code Postal")]
        public string PostalCode { get; set; }

        [Required, Display(Name = "Nom")]
        public string Name { get; set; }

    }
}
