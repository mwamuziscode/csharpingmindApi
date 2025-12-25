// using Bogus;
// using Microsoft.EntityFrameworkCore;
// using System;
// using BCrypt.Net;
// using csharpingmindApi.Models;

// namespace csharpingmindApi.Utility
// {
//     public static class UserModelBuilderExtensions
//     {
//         public static void SeedUser(this ModelBuilder modelBuilder)
//         {
//             // Always include your two specific test users first
//             string v = BC.HashPassword("Passord1234@2025-08-07!");
//             modelBuilder.Entity<Group>().HasData(
//                 new Group
//                 {
//                     Id = 1,
//                     Name = "Admin",
//                     Description = "Administrator group with full permissions",
//                     CanView = true,
//                     CanEdit = true,
//                     CanDelete = true,
//                     CanCreate = true,
//                     IsAdminGroup = true,
//                     CreatedAt = new DateTime(2024, 1, 1, 10, 0, 0),
//                     UpdatedAt = DateTime.UtcNow
//                 }
//             );

//             // Generate 20 additional fake users with Bogus
//             var group_Id = 2; // Start IDs after your hardcoded users
//             var userFaker = new Faker<Group>()
//                 .RuleFor(u => u.Id, f => group_Id++)
//                 .RuleFor(u => u.Name, f => f.Company.CompanyName())
//                 .RuleFor(u => u.Description, f => f.Lorem.Sentence())
//                 .RuleFor(u => u.CanView, f => f.Random.Bool(0.8f)) // 80% chance of CanView being true
//                 .RuleFor(u => u.CanEdit, f => f.Random.Bool(0.5f)) // 50% chance of CanEdit being true
//                 .RuleFor(u => u.CanDelete, f => f.Random.Bool(0.3f)) // 30% chance of CanDelete being true
//                 .RuleFor(u => u.CanCreate, f => f.Random.Bool(0.4f)) // 40% chance of CanCreate being true
//                 .RuleFor(u => u.IsAdminGroup, f => f.Random.Bool(0.1f)) // 10% chance of IsAdminGroup being true
//                 .RuleFor(u => u.CreatedAt, f => f.Date.Past(2))
//                 .RuleFor(u => u.UpdatedAt, f => DateTime.UtcNow);

//             modelBuilder.Entity<Group>().HasData(userFaker.Generate(20)); // Generate 20 fake groups
//         }
//     }
// }