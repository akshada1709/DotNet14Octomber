using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Transactions;

namespace API.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for the entities (models) you want to track
        public DbSet<Transaction> Transactions { get; set; }

        // Add more DbSet properties for other models (if you have any)
        // public DbSet<OtherModel> OtherModels { get; set; }

        // Override the OnModelCreating method to configure the model if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add configurations if needed, like table names, relationships, etc.
            // modelBuilder.Entity<Transaction>().ToTable("Transactions");

            // Example for configuring relationships, if any
            // modelBuilder.Entity<Transaction>()
            //    .HasOne(t => t.User)
            //    .WithMany(u => u.Transactions)
            //    .HasForeignKey(t => t.UserId);
        }
    }
}
