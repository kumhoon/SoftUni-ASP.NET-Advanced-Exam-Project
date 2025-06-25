namespace AspNetCoreArchTemplate.Data.Models
{
    public class ForumSection
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();
    }
}
