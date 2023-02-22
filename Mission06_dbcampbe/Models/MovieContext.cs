using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dbcampbe.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seed Data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Sci-fi" },
                new Category { CategoryId = 3, CategoryName = "Fantasy" },
                new Category { CategoryId = 4, CategoryName = "Adventure" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Horror" },
                new Category { CategoryId = 7, CategoryName = "Musical" },
                new Category { CategoryId = 8, CategoryName = "Sports" },
                new Category { CategoryId = 9, CategoryName = "Romance" }
                );

            mb.Entity<Movie>().HasData(
                //Seeding the movie database with 3 movies
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Tenet",
                    Year = 2020,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Star Wars: Episode I – The Phantom Menace",
                    Year = 1999,
                    Director = "Geroge Lucas",
                    Rating = "PG",
                    Notes = "Really not that bad"
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "The Hobbit: The Desolation of Smaug",
                    Year = 2013,
                    Director = "Peter Jackson",
                    Rating = "PG-13"
                }
            );
        }
    }
}
