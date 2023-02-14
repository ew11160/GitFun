using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    // inheriting from DbContext class
    public class DateApplicationContext : DbContext
    {
        // set up constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationID = 1,
                        FirstName = "Michael",
                        LastName = "Scott",
                        Age = 45,
                        Phone = "555-555-1234",
                        Major = "Sales",
                        CreeperStalker = false
                    },
                    new ApplicationResponse
                    {
                        ApplicationID = 2,
                        FirstName = "Creed",
                        LastName = "Bratton",
                        Age = 90,
                        Phone = "555-123-555",
                        Major = "Undeclared",
                        CreeperStalker = true
                    }
                );
        }
    }
}
