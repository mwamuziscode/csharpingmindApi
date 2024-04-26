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

            modelBuilder.Entity<User>().HasData(new User
            {
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
                LastLogin = new DateTime(2022, 1, 17),
                IsSuperuser = false,
                IsStaff = false,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                GroupId = 1
            },

           new User
                    {
                        Id = 2,
                        UserName = "rhythmixart",
                        Email = "rhythmixart@email.com",
                        Password = "rhythmix1234",
                        FirstName = "Ella",
                        LastName = "Harmony",
                        Age = 25,
                        PhoneNumber = "456-789-123-45",
                        dateOfBirth = new DateTime(1998, 4, 12),
                        IsActive = true,
                        LastLogin = new DateTime(2022, 1, 17),
                        IsSuperuser = false,
                        IsStaff = true,
                        IsDeleted = false,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        GroupId = 2
                    },
    new User
    {
        Id = 3,
        UserName = "canvascreator",
        Email = "canvascreator@artmail.com",
        Password = "create2024",
        FirstName = "Leo",
        LastName = "Brush",
        Age = 30,
        PhoneNumber = "789-012-345-67",
        dateOfBirth = new DateTime(1993, 7, 23),
        IsActive = true,
        LastLogin = new DateTime(2022, 1, 17),
        IsSuperuser = false,
        IsStaff = false,
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        GroupId = 3
    },
    new User
    {
        Id = 4,
        UserName = "pixelpainter",
        Email = "pixelpainter@artstudio.com",
        Password = "pixelsafe123",
        FirstName = "Maya",
        LastName = "Pixels",
        Age = 22,
        PhoneNumber = "101-112-131-41",
        dateOfBirth = new DateTime(2001, 11, 1),
        IsActive = true,
        LastLogin = new DateTime(2022, 1, 17),
        IsSuperuser = false,
        IsStaff = true,
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        GroupId = 1
    },
    new User
    {
        Id = 5,
        UserName = "thecolorist",
        Email = "thecolorist@paintmail.com",
        Password = "colorworld222",
        FirstName = "Tom",
        LastName = "Palette",
        Age = 28,
        PhoneNumber = "212-313-414-51",
        dateOfBirth = new DateTime(1995, 5, 5),
        IsActive = false,
        LastLogin = new DateTime(2022, 1, 17),
        IsSuperuser = false,
        IsStaff = false,
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        GroupId = 2
    },
    new User
    {
        Id = 6,
        UserName = "shade_master",
        Email = "shade_master@shade.com",
        Password = "shady777",
        FirstName = "Jenna",
        LastName = "Shadow",
        Age = 34,
        PhoneNumber = "323-424-525-62",
        dateOfBirth = new DateTime(1989, 3, 18),
        IsActive = true,
        LastLogin = new DateTime(2022, 1, 17),
        IsSuperuser = false,
        IsStaff = true,
        IsDeleted = false,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        GroupId = 1
    });
            
            modelBuilder.Entity<Permission>().HasData(new Permission { Id = 1, Name = "Admin", Description = "The user have the views right", ContentTypeId = 1, CodeName = "view_article"});

            modelBuilder.Entity<BlogPost>().HasData(new BlogPost
            {
                Id = 1, // Since Id is auto-generated, ensure it's set if needed for seeding, otherwise it's managed by the DB.
                Title = "First Blog Post",
                Images = "default.jpg", 
                UpdatedOn = DateTime.UtcNow, 
                Content = "This is the content of the first blog post.",
                CreatedOn = DateTime.UtcNow,
                Status = 1, 
                AuthorId = 1 
            });

        }
    }
}
