using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertCentral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ConcertCentral.Pages
{
    public class BandsPerformingModel : PageModel
    {
        private AppDbContext _context;

        public BandsPerformingModel(AppDbContext context) {
            _context = context;
        }
        public Band Band { get; set; }
        public IActionResult OnGet(int? id)
        {
            if(id == null){
                return NotFound();
            }
             Band = _context.Band
            .Include(est => est.Concerts)
            .FirstOrDefault(est => est.Id == id);

            if (Band == null) {
            return NotFound();
            }
                                  
        return Page();
        }
    }
}