﻿using Microsoft.EntityFrameworkCore;
using System.Security;
using System.Text.RegularExpressions;

namespace csharpingmindApi.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                  entity.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(255)

                  // Ensure password is hashed and not stored in plain text
                    .HasConversion(v => BC.HashPassword(v), v => v); // Store only hashed passwords




                entity.Property(e => e.FirstName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.LastName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP")
                      .ValueGeneratedOnAddOrUpdate();
            });
            modelBuilder.Seed();
        }
    }
}
