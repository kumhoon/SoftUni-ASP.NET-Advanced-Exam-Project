using AspNetCoreArchTemplate.Data;
using AspNetCoreArchTemplate.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreArchTemplate.Web.Pages
{
    public class OffTopicModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Data.Models.Thread> Threads { get; set; } = new List<Data.Models.Thread>();

        public OffTopicModel(ApplicationDbContext context)
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
