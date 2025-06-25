namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class UserProfile
    {
        public int Id { get; set; }
        public string IdentityUserId { get; set; } = null!;

        public IdentityUser IdentityUser { get; set; } = null!;

        public string ForumRank { get; set; } = null!;
        public int TotalPosts { get; set; }
        public int TotalComments { get; set; }
    }
}
