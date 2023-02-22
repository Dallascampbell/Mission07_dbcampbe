﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_dbcampbe.Models;

namespace Mission06_dbcampbe.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_dbcampbe.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Sci-fi"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Romance"
                        });
                });

            modelBuilder.Entity("Mission06_dbcampbe.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Tenet",
                            Year = 2020
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Geroge Lucas",
                            Edited = false,
                            Notes = "Really not that bad",
                            Rating = "PG",
                            Title = "Star Wars: Episode I – The Phantom Menace",
                            Year = 1999
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Peter Jackson",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Hobbit: The Desolation of Smaug",
                            Year = 2013
                        });
                });

            modelBuilder.Entity("Mission06_dbcampbe.Models.Movie", b =>
                {
                    b.HasOne("Mission06_dbcampbe.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
