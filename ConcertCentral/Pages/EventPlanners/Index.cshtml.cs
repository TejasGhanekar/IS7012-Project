using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConcertCentral.Models;

namespace ConcertCentral.Pages.EventPlanners
{
    public class IndexModel : PageModel
    {
        private readonly ConcertCentral.Models.AppDbContext _context;

        public IndexModel(ConcertCentral.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<EventPlanner> EventPlanner { get;set; }

        public async Task OnGetAsync()
        {
            EventPlanner = await _context.EventPlanner.ToListAsync();
        }
    }
}
