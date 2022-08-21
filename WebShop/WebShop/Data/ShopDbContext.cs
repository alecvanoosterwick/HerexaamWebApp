using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Areas.Identity.Data;
using WebShop.Models;

namespace WebShop.Data
{
    public class ShopDbContext : IdentityDbContext<WebShopUser>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }
        public DbSet<Spel> Spellen { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<Inzet> Inzetten { get; set; }
        public DbSet<Foto> Fotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Product>().ToTable("Product").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Bestelling>().ToTable("Bestelling");
            modelBuilder.Entity<Bestelling>()
                .HasOne<Klant>(k => k.Klant)
                .WithMany(b => b.Bestellingen)
                .HasForeignKey(a => a.KlantId);
            modelBuilder.Entity<Bestelling>()
                .HasOne<Product>(p => p.Product)
                .WithMany(k => k.Bestelling)
                .HasForeignKey(a => a.ProductId);
            modelBuilder.Entity<Spel>().ToTable("Spel").Property(p => p.TotaleInzet).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Inzet>().ToTable("Inzet").Property(p => p.Bedrag).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Foto>().ToTable("Foto").Property(p => p.Breedte).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Foto>().Property(p => p.Hoogte).HasColumnType("decimal(18,2)");
        }
    }
}
