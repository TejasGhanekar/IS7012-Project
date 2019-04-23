using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConcertCentral.Models;

namespace ConcertCentral.Pages.EventPlanners
{
    public class CreateModel : PageModel
    {
        private readonly ConcertCentral.Models.AppDbContext _context;

        public CreateModel(ConcertCentral.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EventPlanner EventPlanner { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EventPlanner.Add(EventPlanner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}