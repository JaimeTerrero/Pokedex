using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Typee> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FLUENT API

            #region tables
            modelBuilder.Entity<Pokemon>().ToTable("Pokemons");
            modelBuilder.Entity<Region>().ToTable("Regions");
            modelBuilder.Entity<Typee>().ToTable("Types");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Pokemon>().HasKey(pokemon => pokemon.Id);
            modelBuilder.Entity<Region>().HasKey(region => region.Id);
            modelBuilder.Entity<Typee>().HasKey(type => type.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Region>()
                .HasMany<Pokemon>(region => region.Pokemons)
                .WithOne(pokemon => pokemon.Region)
                .HasForeignKey(pokemon => pokemon.RegionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Typee>()
                .HasMany<Pokemon>(type => type.PokemonsPrimary)
                .WithOne(pokemon => pokemon.Type)
                .HasForeignKey(pokemon => pokemon.TipoPrimario)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property configurations"

            #region pokemons

            modelBuilder.Entity<Pokemon>().Property(pokemon => pokemon.Name).IsRequired();
            modelBuilder.Entity<Pokemon>().Property(pokemon => pokemon.RegionId).IsRequired();
            modelBuilder.Entity<Pokemon>().Property(pokemon => pokemon.ImageUrl).IsRequired();
            modelBuilder.Entity<Pokemon>().Property(pokemon => pokemon.TipoPrimario).IsRequired();
            #endregion

            #region regions
            modelBuilder.Entity<Region>().Property(region => region.Name).IsRequired().HasMaxLength(100);
            #endregion

            #region types
            modelBuilder.Entity<Typee>().Property(type => type.Name).IsRequired().HasMaxLength(100);
            #endregion

            #endregion

        }
    }
}
