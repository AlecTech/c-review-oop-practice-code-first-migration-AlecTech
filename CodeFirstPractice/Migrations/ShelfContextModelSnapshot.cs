﻿// <auto-generated />
using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstPractice.Migrations
{
    [DbContext(typeof(ShelfContext))]
    partial class ShelfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstPractice.Models.Shelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("shelfs");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Item1"
                        },
                        new
                        {
                            ID = -2,
                            Name = "Item2"
                        },
                        new
                        {
                            ID = -3,
                            Name = "Item3"
                        },
                        new
                        {
                            ID = -4,
                            Name = "Item4"
                        },
                        new
                        {
                            ID = -5,
                            Name = "Item5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
