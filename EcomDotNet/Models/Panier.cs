namespace EcomDotNet.Models
{
    public class Panier
    {

        public int PanierID { get; set; }


        public string? PanierDesc { get; set; }

        public ICollection<Commande>? Commandes { get; set; }
    }
}
