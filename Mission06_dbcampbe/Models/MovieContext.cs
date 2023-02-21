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


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                //Seeding the movie database with 3 movies
                new Movie
                {
                    MovieID = 1,
                    Category = "Action/Sci-fi",
                    Title = "Tenet",
                    Year = 2020,
                    Director = "Christopher Nolan",
                    Rating = "PG-13"
                },
                new Movie
                {
                    MovieID = 2,
                    Category = "Sci-fi/Adventure",
                    Title = "Star Wars: Episode I – The Phantom Menace",
                    Year = 1999,
                    Director = "Geroge Lucas",
                    Rating = "PG",
                    Notes = "Really not that bad"
                },
                new Movie
                {
                    MovieID = 3,
                    Category = "Adventure/Fantasy",
                    Title = "The Hobbit: The Desolation of Smaug",
                    Year = 2013,
                    Director = "Peter Jackson",
                    Rating = "PG-13"
                }
            );
        }
    }
}
