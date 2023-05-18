namespace EcomDotNet.Models
{
    public class LignePanier
    {

        public string? LignePanierID { get; set; }


        public int LigneQuantité { get; set; }

        public int ProductID { get; set; }
        public virtual Produit? Produit { get; set; }

        public Commande? Commande { get; set; }
    }
}
