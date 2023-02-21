using Microsoft.EntityFrameworkCore;
using Mission06_ea11160.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ea11160.Models
{
    // inhert from DbContext class
    public class MovieEntryContext : DbContext
    {
        // Constructor
        public MovieEntryContext (DbContextOptions<MovieEntryContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<MovieEntryModel> MovieEntries { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                
                new Category { CategoryID = 1, CategoryName = "Action"},
                new Category { CategoryID = 2, CategoryName = "Adventure" },
                new Category { CategoryID = 3, CategoryName = "Comedy"},
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Fantasy" },
                new Category { CategoryID = 6, CategoryName = "Mystery"},
                new Category { CategoryID = 7, CategoryName = "Romance" },
                new Category { CategoryID = 8, CategoryName = "Sports" },
                new Category { CategoryID = 9, CategoryName = "Western"}
                );

            mb.Entity<MovieEntryModel>().HasData(
                    
                    new MovieEntryModel
                    {
                        MovieID = 1,
                        CategoryID = 7,
                        Title = "Your Place Or Mine",
                        Year = 2023,
                        Director = "Netflix",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "Cute, but why can't Ryan Reynolds be in every movie?"
                    },
                    new MovieEntryModel
                    {
                        MovieID = 2,
                        CategoryID = 1,
                        Title = "The Hunt for Red October",
                        Year = 1990,
                        Director = "John McTiernan",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "",
                        Notes = "Awesome Movie!"
                    },
                    new MovieEntryModel
                    {
                        MovieID = 3,
                        CategoryID = 2,
                        Title = "Pocahontas",
                        Year = 1995,
                        Director = "Disney",
                        Rating = "G",
                        Edited = true,
                        LentTo = "Rosey",
                        Notes = "Jake's pre-church movie this week."
                    }
                );
        }
    }
}
