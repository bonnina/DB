using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DB.Models;

namespace DB.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly DB.Data.Context _context;

        public IndexModel(DB.Data.Context context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; }

        public async Task OnGetAsync()
        {
            Worker = await _context.Workers.ToListAsync();
        }
    }
}
