﻿// <auto-generated />
using System;
using EcomDotNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcomDotNet.Migrations
{
    [DbContext(typeof(EcomDotNetContext))]
    [Migration("20230131211050_ISBNmig")]
    partial class ISBNmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcomDotNet.Models.Commande", b =>
                {
                    b.Property<int>("CmdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CmdID"));

                    b.Property<int?>("PanierID")
                        .HasColumnType("int");

                    b.HasKey("CmdID");

                    b.HasIndex("PanierID");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("EcomDotNet.Models.LignePanier", b =>
                {
                    b.Property<string>("LignePanierID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CommandeCmdID")
                        .HasColumnType("int");

                    b.Property<int>("LigneQuantité")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("ProduitProductID")
                        .HasColumnType("int");

                    b.HasKey("LignePanierID");

                    b.HasIndex("CommandeCmdID");

                    b.HasIndex("ProduitProductID");

                    b.ToTable("LignePanier");
                });

            modelBuilder.Entity("EcomDotNet.Models.Panier", b =>
                {
                    b.Property<int>("PanierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PanierID"));

                    b.Property<string>("PanierDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PanierID");

                    b.ToTable("Panier");
                });

            modelBuilder.Entity("EcomDotNet.Models.Produit", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductISBN")
                        .HasColumnType("int");

                    b.Property<string>("ProductImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("EcomDotNet.Models.Commande", b =>
                {
                    b.HasOne("EcomDotNet.Models.Panier", "Panier")
                        .WithMany("Commandes")
                        .HasForeignKey("PanierID");

                    b.Navigation("Panier");
                });

            modelBuilder.Entity("EcomDotNet.Models.LignePanier", b =>
                {
                    b.HasOne("EcomDotNet.Models.Commande", "Commande")
                        .WithMany("LPanier")
                        .HasForeignKey("CommandeCmdID");

                    b.HasOne("EcomDotNet.Models.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitProductID");

                    b.Navigation("Commande");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("EcomDotNet.Models.Commande", b =>
                {
                    b.Navigation("LPanier");
                });

            modelBuilder.Entity("EcomDotNet.Models.Panier", b =>
                {
                    b.Navigation("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}
