namespace AspNetCoreArchTemplate.Data.Configuration
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> entity)
        {
            entity
                .HasKey(up => up.Id);

            
            entity.HasKey(up => up.Id);

            
            entity
                .Property(up => up.IdentityUserId)
                .IsRequired();

            entity
                .HasOne(up => up.IdentityUser)
                .WithOne()
                .HasForeignKey<UserProfile>(up => up.IdentityUserId)
                .OnDelete(DeleteBehavior.Cascade);

            
            entity
                .Property(up => up.ForumRank)
                .HasConversion<string>() 
                .IsRequired();

            entity
                .Property(up => up.TotalPosts)
                .IsRequired()
                .HasDefaultValue(0);

            entity
                .Property(up => up.TotalComments)
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
