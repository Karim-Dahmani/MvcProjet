using System.ComponentModel.DataAnnotations;

namespace EcomDotNet.Models
{
    public class Produit
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;


        public string? ProductImg { get; set; }

        public decimal ProductPrice { get; set; }

        public string? ProductDescription { get; set; }

        public int ProductISBN { get; set; }


    }
}
