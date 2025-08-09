using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using BCrypt.Net;
using csharpingmindApi.Models;

// Bycrypt.Net.BCrypt is used for hashing passwords securely
// Ensure you have the BCrypt.Net-Next package installed in your project


public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Always include your two specific test users first
        string v = BC.HashPassword("Passord1234@2025-08-07!");
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserName = "johndoe",
                Email = "johndoe@example.com",
                Password = v,
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                PhoneNumber = "+1234567890",
                DateOfBirth = new DateTime(1993, 5, 15),
                IsActive = true,
                LastLogin = DateTime.UtcNow.AddDays(-1),
                IsSuperuser = false,
                IsStaff = true,
                IsDeleted = false,
                //Group = "Staff",
                CreatedAt = new DateTime(2024, 1, 1, 10, 0, 0),
                UpdatedAt = DateTime.UtcNow
            }
        );

        // Generate 20 additional fake users with Bogus
        var userId = 2; // Start IDs after your hardcoded users
        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => userId++)
            .RuleFor(u => u.UserName, f => f.Internet.UserName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.Password, f => BC.HashPassword("Test123!")) // Standard password for all fake users
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Age, f => f.Random.Number(18, 65))
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("+1##########"))
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(30, DateTime.Now.AddYears(-18)))
            .RuleFor(u => u.IsActive, f => f.Random.Bool(0.9f)) // 90% chance of being active
            .RuleFor(u => u.LastLogin, f => f.Date.Recent(30))
            .RuleFor(u => u.IsSuperuser, f => f.Random.Bool(0.1f)) // 10% chance
            .RuleFor(u => u.IsStaff, f => f.Random.Bool(0.3f)) // 30% chance
            .RuleFor(u => u.IsDeleted, f => f.Random.Bool(0.05f)) // 5% chance
            //.RuleFor(u => u.Group, f => f.PickRandom("Users", "Developers", "QA", "Managers"))
            .RuleFor(u => u.CreatedAt, f => f.Date.Past(2))
            .RuleFor(u => u.UpdatedAt, f => DateTime.UtcNow);

        modelBuilder.Entity<User>().HasData(userFaker.Generate(20)); // Generate 20 fake users
    }
}