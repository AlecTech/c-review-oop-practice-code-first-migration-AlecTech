using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPractice.Models
{
    class ShelfContext : DbContext 
    {
        public virtual DbSet<Shelf> Shelfs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //	Use Entity Framework to create a database called “codefirst_practice” using your models.
            if (!optionsBuilder.IsConfigured)
            {
                string connection =
                    "server=localhost;" +
                    "port=3306;" +
                    "user=root;" +
                    "database=codefirst_practice;";

                string version = "10.4.14-MariaDB";

                optionsBuilder.UseMySql(connection, x => x.ServerVersion(version));
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelf>(entity =>
            {
                //collation only Text fields not intiger fields
                entity.Property( e => e.Name)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

            });
        
        }
    }
}
