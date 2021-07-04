using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DB.Data;
using DB.Models;

namespace DB.Pages.Animals
{
    public class IndexModel : PageModel
    {
        private readonly DB.Data.Context _context;

        public IndexModel(DB.Data.Context context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; }

        public async Task OnGetAsync()
        {
            Animal = await _context.Animals.ToListAsync();
        }
    }
}
