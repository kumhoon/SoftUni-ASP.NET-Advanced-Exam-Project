namespace AspNetCoreArchTemplate.Data.Configuration
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ModeratorAssignmentConfiguration : IEntityTypeConfiguration<ModeratorAssignment>
    {
        public void Configure(EntityTypeBuilder<ModeratorAssignment> entity)
        {
            entity
                .HasKey(ma => ma.Id);

            // A moderator can only moderate one section
            entity
                .HasIndex(ma => ma.UserId)
                .IsUnique();
  
            entity
                .HasOne(ma => ma.User)
                .WithMany()
                .HasForeignKey(ma => ma.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            entity
                .HasOne(ma => ma.ForumSection)
                .WithMany()
                .HasForeignKey(ma => ma.ForumSectionId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
