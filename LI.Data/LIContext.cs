using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LI.Core.Domain;


namespace LI.Data
{
    public class LIContext : DbContext
    {
        public DbSet<Camion> Camions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Colis> Colis { get; set; }
        public DbSet<Voiture> Voitures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                              Initial Catalog=LivTahaNaat;
                                              Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colis>()
                .HasKey(c => new { c.ClientFK, c.LivreurFK, c.DateLivraison });

            modelBuilder.Entity<Conduite>()
                .ToTable("Conduite")
                .HasKey(c => new { c.LivreurId, c.VehicleMatricule });

            modelBuilder.Entity<Vehicule>()
                .ToTable("Vehicule")
                .HasDiscriminator<string>("Type")
                .HasValue<Voiture>("Voiture")
                .HasValue<Camion>("Camion");
        }
    }
}
