using System.Collections.Generic;
using Integrate.Interview.Frontend.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Integrate.Interview.Frontend.Database
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new List<Person>
            {
                new()
                {
                    Id = 1,
                    FirstName = "Hunter",
                    LastName = "Horton",
                    StreetAddress = "123 Mockingbird Lane",
                    City = "Birmingham",
                    State = "Alabama",
                    Zipcode = "35242",
                    Title = "Mr"
                },
                new()
                {
                    Id = 2,
                    FirstName = "Aaron",
                    LastName = "Hall",
                    StreetAddress = "777 Sunshine Drive",
                    City = "Birmingham",
                    State = "Alabama",
                    Zipcode = "35242",
                    Title = "Mr"
                },
                new()
                {
                    Id = 3,
                    FirstName = "Robert",
                    LastName = "Blackwood",
                    StreetAddress = "1 Pleasant Way",
                    City = "Birmingham",
                    State = "Alabama",
                    Zipcode = "35242",
                    Title = "Mr"
                },
                new()
                {
                    Id = 4,
                    FirstName = "Scott",
                    LastName = "Carl",
                    StreetAddress = "246 Yellowhammer Circle",
                    City = "Birmingham",
                    State = "Alabama",
                    Zipcode = "35242",
                    Title = "Mr"
                },
                new()
                {
                    Id = 5,
                    FirstName = "Andrew",
                    LastName = "Pearson",
                    StreetAddress = "357 Oriole Parkway",
                    City = "Birmingham",
                    State = "Alabama",
                    Zipcode = "35242",
                    Title = "Mr"
                },
            });
        }
    }
}