namespace AspNetCoreArchTemplate.Data.Configuration
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static AspNetCoreArchTemplate.Data.Common.DbEntityValidationConstants.ForumSection;

    public class ForumSectionConfiguration : IEntityTypeConfiguration<ForumSection>
    {
        public void Configure(EntityTypeBuilder<ForumSection> entity)
        {
            entity
                .HasKey(fs => fs.Id);

            entity
                .Property(fs => fs.Name)
                .IsRequired()
                .HasMaxLength(ForumSectionNameMaxLength);

            entity
                .Property(fs => fs.Description)
                .IsRequired()
                .HasMaxLength(ForumSectionDescriptionMaxLength);

            entity
                .HasMany(fs => fs.Threads)
                .WithOne(t => t.ForumSection)
                .HasForeignKey(t => t.ForumSectionId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
