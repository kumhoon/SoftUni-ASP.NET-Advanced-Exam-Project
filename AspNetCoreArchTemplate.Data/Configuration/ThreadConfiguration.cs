namespace AspNetCoreArchTemplate.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using AspNetCoreArchTemplate.Data.Models;
    using static AspNetCoreArchTemplate.Data.Common.DbEntityValidationConstants.Thread;

    public class ThreadConfiguration : IEntityTypeConfiguration<Thread>
    {
        public void Configure(EntityTypeBuilder<Thread> entity)
        {
            entity
                .HasKey(t => t.Id);

            entity
                .Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(ThreadTitleMaxLength);

            entity
                .Property(t=> t.Content)
                .IsRequired()
                .HasMaxLength(ThreadContentMaxLength);

            entity
                .Property(t => t.IsDeleted)
                .HasDefaultValue(false);

            entity
                .HasQueryFilter(t => t.IsDeleted == false);

            entity
                .HasOne(t => t.ForumSection)
                .WithMany(fs => fs.Threads)
                .HasForeignKey(t => t.ForumSectionId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(t => t.ThreadCreator)
                .WithMany()
                .HasForeignKey(t=> t.ThreadCreatorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
