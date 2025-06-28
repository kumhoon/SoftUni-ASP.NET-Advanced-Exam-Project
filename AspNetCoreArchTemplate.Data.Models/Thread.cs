namespace AspNetCoreArchTemplate.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class Thread
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public int ForumSectionId { get; set; }

        public ForumSection ForumSection { get; set; } = null!;

        public string ThreadCreatorId { get; set; } = null!;

        public virtual IdentityUser ThreadCreator { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
