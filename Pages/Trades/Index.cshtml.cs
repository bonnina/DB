using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DB.Models;

namespace DB.Pages.Trades
{
    public class IndexModel : PageModel
    {
        private readonly DB.Data.Context _context;

        public IndexModel(DB.Data.Context context)
        {
            _context = context;
        }

        public IList<Trade> Trade { get;set; }

        public async Task OnGetAsync()
        {
            Trade = await _context.Trades.ToListAsync();
        }
    }
}
