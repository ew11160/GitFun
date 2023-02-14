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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntryModel>().HasData(
                    
                    new MovieEntryModel
                    {
                        MovieID = 1,
                        Category = "Rom-Com",
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
                        Category = "Action",
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
                        Category = "Animated",
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
