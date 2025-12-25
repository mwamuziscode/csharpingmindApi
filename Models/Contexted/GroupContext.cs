using csharpingmindApi.Models;
using Microsoft.EntityFrameworkCore;
namespace csharpingmindApi.Models.Contexted;






public class GroupContext(DbContextOptions<GroupContext> options) : DbContext(options)
{
    public DbSet<Group> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("Group");

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

