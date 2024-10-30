using Microsoft.EntityFrameworkCore;
using PokemonReviewer.Models;

namespace PokemonReviewer.Data
{
    public class DataContext : DbContext
    {
        // tf is this?
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.CategoryId, pc.PokemonId });
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(pc => pc.Pokemon)
                .WithMany(dc => dc.PokemonCategories)
                .HasForeignKey(pc => pc.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(dc => dc.PokemonCategories)
                .HasForeignKey(pc => pc.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                .HasKey(po => new { po.OwnerId, po.PokemonId });
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(po => po.Pokemon)
                .WithMany(dc => dc.PokemonOwners)
                .HasForeignKey(po => po.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(po => po.Owner)
                .WithMany(dc => dc.PokemonOwners)
                .HasForeignKey(po => po.OwnerId);

        }
    }

}
