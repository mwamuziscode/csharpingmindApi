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
				.HasMany(c => c.Users)
				.WithOne(a => a.Group)
				.HasForeignKey(a => a.GroupId);

			modelBuilder.Seed();
	}
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}