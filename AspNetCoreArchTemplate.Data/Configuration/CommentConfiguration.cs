namespace AspNetCoreArchTemplate.Data.Configuration
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static AspNetCoreArchTemplate.Data.Common.DbEntityValidationConstants.Comment;

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> entity)
        {
            entity
                .HasKey(c => c.Id);

            entity
                .Property(c => c.Content)
                .IsRequired()
                .HasMaxLength(CommentContentMaxLength);

            entity
                .Property (c => c.IsDeleted)
                .HasDefaultValue (false);

            entity
                .HasQueryFilter(c => c.IsDeleted == false);

            
            entity
                .HasOne(c => c.Commenter)
                .WithMany()
                .HasForeignKey(c => c.CommenterId)
                .OnDelete (DeleteBehavior.Restrict);

            entity
                .HasOne(c => c.Thread)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.ThreadId)
                .OnDelete (DeleteBehavior.Restrict);


        }
    }
}
