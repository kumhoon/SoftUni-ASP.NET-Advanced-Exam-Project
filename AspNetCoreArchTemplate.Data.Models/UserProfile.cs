namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class UserProfile
    {
        public int Id { get; set; }
        public string IdentityUserId { get; set; } = null!;

        public IdentityUser IdentityUser { get; set; } = null!;

        public ForumRank ForumRank { get; set; }
        public int TotalPosts { get; set; }
        public int TotalComments { get; set; }
    }

    public enum ForumRank
    {
        Newbie,
        Member,
        Veteran,
        Elite
    }
}
