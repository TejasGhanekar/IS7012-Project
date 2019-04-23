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
    public class DeleteModel : PageModel
    {
        private readonly ConcertCentral.Models.AppDbContext _context;

        public DeleteModel(ConcertCentral.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EventPlanner EventPlanner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventPlanner = await _context.EventPlanner.FirstOrDefaultAsync(m => m.Id == id);

            if (EventPlanner == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventPlanner = await _context.EventPlanner.FindAsync(id);

            if (EventPlanner != null)
            {
                _context.EventPlanner.Remove(EventPlanner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
