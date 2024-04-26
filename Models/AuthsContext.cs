using System;
using Microsoft.EntityFrameworkCore;

namespace csharpingmindApi.Models
{ 
	public class AuthsContext : DbContext
    {
		public AuthsContext(DbContextOptions<AuthsContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Group>()
                //  one-to-many relationship
                .HasMany(c => c.Users)
                // one - to - many relationship
                .WithOne(a => a.Group)
                // use as the foreign key for this relationship
                .HasForeignKey(a => a.GroupId);

            modelBuilder.Entity<Permission>()
                .HasKey(p => p.Id); // set the primary key

            modelBuilder.Entity<Permission>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(128); // constraints for name

            modelBuilder.Entity<Permission>()
                .HasIndex(p => p.CodeName)
                .IsUnique();



            modelBuilder.Seed();
        }
        
       
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; } 
        public DbSet<Permission> Permissions { get; set; }
        
    }
}