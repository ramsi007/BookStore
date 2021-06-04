using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Categorie")]
        [Required(ErrorMessage = "Entrez un nom de catégorie")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
