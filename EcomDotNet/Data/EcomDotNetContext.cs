using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcomDotNet.Models;

namespace EcomDotNet.Data
{
    public class EcomDotNetContext : DbContext
    {
        public EcomDotNetContext (DbContextOptions<EcomDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<EcomDotNet.Models.Produit> Produit { get; set; } = default!;

        public DbSet<EcomDotNet.Models.Panier> Panier { get; set; } = default!;

        public DbSet<EcomDotNet.Models.Commande> Commande { get; set; } = default!;

        public DbSet<EcomDotNet.Models.LignePanier> LignePanier { get; set; } = default!;
    }
}
