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
        public DbSet<Major> Majors { get; set; }

        // Seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Major>().HasData(
                    new Major { MajorId = 1, MajorName = "Information Systems"},
                    new Major { MajorId = 2, MajorName = "Ancient Near Eastern Studies: Greek New Testament"},
                    new Major { MajorId = 3, MajorName = "Accounting"},
                    new Major { MajorId = 4, MajorName = "Actuarial Science" },
                    new Major { MajorId = 5, MajorName = "Undeclared"}
                );
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationID = 1,
                        FirstName = "Michael",
                        LastName = "Scott",
                        Age = 45,
                        Phone = "555-555-1234",
                        MajorId = 4,
                        CreeperStalker = false
                    },
                    new ApplicationResponse
                    {
                        ApplicationID = 2,
                        FirstName = "Creed",
                        LastName = "Bratton",
                        Age = 90,
                        Phone = "555-123-555",
                        MajorId = 5,
                        CreeperStalker = true
                    }
                );
        }
    }
}
