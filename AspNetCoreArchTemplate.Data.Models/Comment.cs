namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class Comment
    {
        public int Id { get; set; }

        public string CommenterId { get; set; } = null!;

        public IdentityUser Commenter { get; set; } = null!;

        public string Content { get; set; } = null!;

        public int ThreadId { get; set; }

        public Thread Thread { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
