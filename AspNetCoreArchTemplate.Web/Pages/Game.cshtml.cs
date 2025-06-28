

namespace AspNetCoreArchTemplate.Web.Pages
{
    using AspNetCoreArchTemplate.Data;
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    public class GameModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Thread> Threads { get; set; } = new List<Thread>();

        public GameModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Threads = await _context.Threads
                .Include(t => t.ThreadCreator)
                .Where(t => t.ForumSection.Name == "Game")
                .OrderByDescending(t => t.Id)
                .ToListAsync();
        }
    }
}
