namespace AspNetCoreArchTemplate.Data.Configuration
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FriendshipConfiguration : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> entity)
        {
            entity
                .HasKey(f => new {f.RequesterId, f.AddresseeId});

            entity
                .Property(f => f.RequestedAt)
                .IsRequired();

            entity
                .Property(f => f.Status)
                .IsRequired()
                .HasConversion<string>(); 

            entity
                .HasOne(f => f.Requester)
                .WithMany()
                .HasForeignKey(f => f.RequesterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(f => f.Addressee)
                .WithMany()
                .HasForeignKey(f => f.AddresseeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique constraint to prevent duplicate friendships (in either direction)
            entity
                .HasIndex(f => new { f.RequesterId, f.AddresseeId })
                .IsUnique();

            // Check constraint to prevent self-friendship
            entity
                .ToTable(t => t.HasCheckConstraint("CK_Friendship_NoSelfReference", "[RequesterId] <> [AddresseeId]"));


        }
    }
}
