using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharpingmindApi.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Example of seeding data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "johndoe",
                    Email = "johndoe@example.com",
                    Password = "Password123!",
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30,
                    PhoneNumber = "+1234567890",
                    DateOfBirth = new DateTime(1993, 5, 15),
                    IsActive = true,
                    LastLogin = new DateTime(2024, 5, 15, 8, 30, 0),
                    IsSuperuser = false,
                    IsStaff = true,
                    IsDeleted = false,
                    CreatedAt = new DateTime(2024, 1, 1, 10, 0, 0),
                    UpdatedAt = new DateTime(2024, 5, 15, 9, 0, 0)
                },
                new User
                {
                    Id = 2,
                    UserName = "janedoe",
                    Email = "janedoe@example.com",
                    Password = "SecurePass456!",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 28,
                    PhoneNumber = "+0987654321",
                    DateOfBirth = new DateTime(1995, 8, 25),
                    IsActive = true,
                    LastLogin = new DateTime(2024, 5, 15, 10, 0, 0),
                    IsSuperuser = true,
                    IsStaff = true,
                    IsDeleted = false,
                    CreatedAt = new DateTime(2024, 1, 15, 12, 0, 0),
                    UpdatedAt = new DateTime(2024, 5, 15, 10, 30, 0)
                }
            );

            // Ensure all braces are properly closed
        }
    }
}
