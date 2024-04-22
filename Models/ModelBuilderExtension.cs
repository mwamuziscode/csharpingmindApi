using System;
using Microsoft.EntityFrameworkCore;


namespace csharpingmindApi.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
        // TODO: Add constructor logic here
        modelBuilder.Entity<Group>().HasData(new Group { Id = 1, Name = "Admin", Description = "The admin can do anythings" });


        modelBuilder.Entity<User>().HasData(new User {
                    Id = 1,
                    UserName = "mwamuziscodev",
                    Email = "mwamuziscodev@gmail.com",
                    Password = "mwamuziscode123",
                    FirstName = "Judge",
                    LastName = "Scodev",
                    Age = 17,
                    PhoneNumber = "123-223-234-22",
                    dateOfBirth = new DateTime(2022, 1, 17),
                    IsActive = false,
                    IsSuperuser = false,
                    IsStaff = false,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    GroupId = 1 
                });
        }
    }
}
