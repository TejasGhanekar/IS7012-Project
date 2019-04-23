using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConcertCentral.Models;

namespace ConcertCentral.Pages.EventPlanners
{
    public class EditModel : PageModel
    {
        private readonly ConcertCentral.Models.AppDbContext _context;

        public EditModel(ConcertCentral.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EventPlanner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventPlannerExists(EventPlanner.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventPlannerExists(int id)
        {
            return _context.EventPlanner.Any(e => e.Id == id);
        }
    }
}
