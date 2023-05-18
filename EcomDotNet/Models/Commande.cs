using System.ComponentModel.DataAnnotations;

namespace EcomDotNet.Models
{
    public class Commande
    {
        [Key]
        public int CmdID { get; set; }

        public Panier? Panier { get; set; }
        public ICollection<LignePanier>? LPanier { get; set; }
    }
}
