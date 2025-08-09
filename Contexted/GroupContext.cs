using Microsoft.EntityFrameworkCore;
using System.Security;
using System.Text.RegularExpressions;

namespace csharpingmindApi.Models


{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options) : base(options) { }

        public DbSet<AuthGroup> AuthGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("AuthGroup");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Description)
                      .HasMaxLength(200);

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP")
                      .ValueGeneratedOnAddOrUpdate();
            });
        }
    }
}

