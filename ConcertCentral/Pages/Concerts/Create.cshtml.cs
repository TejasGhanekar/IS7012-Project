using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConcertCentral.Models;

namespace ConcertCentral.Pages.Concerts
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
            
        ViewData["BandId"] = new SelectList(_context.Band, "Id", "Name");
        ViewData["EventPlannerId"] = new SelectList(_context.EventPlanner, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Concert Concert { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["BandId"] = new SelectList(_context.Band, "Id", "Name");
                ViewData["EventPlannerId"] = new SelectList(_context.EventPlanner, "Id", "Name");
                return Page();
            }

            _context.Concert.Add(Concert);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}