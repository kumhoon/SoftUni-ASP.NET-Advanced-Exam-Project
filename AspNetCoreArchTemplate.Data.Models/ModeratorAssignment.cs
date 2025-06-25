namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ModeratorAssignment
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;

        public int ForumSectionId { get; set; }
        public ForumSection ForumSection { get; set; } = null!;
    }
}
