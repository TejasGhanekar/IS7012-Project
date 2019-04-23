using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConcertCentral.Models;

namespace ConcertCentral.Pages.Concerts
{
    public class IndexModel : PageModel
    {
        private readonly ConcertCentral.Models.AppDbContext _context;

        public IndexModel(ConcertCentral.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Concert> Concert { get;set; }

        public async Task OnGetAsync()
        {
            Concert = await _context.Concert
                .Include(c => c.Band)
                .Include(c => c.EventPlanner).ToListAsync();
        }
    }
}
