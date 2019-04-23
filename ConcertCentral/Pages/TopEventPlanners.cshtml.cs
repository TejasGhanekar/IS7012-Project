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
    public class TopEventPlannersModel : PageModel
    {
        private AppDbContext _context;

        public TopEventPlannersModel(AppDbContext context) {
            _context = context;
        }
        public EventPlanner EventPlanner { get; set; }
        public IActionResult OnGet(int? id)
        {
            if(id == null){
                return NotFound();
            }
            EventPlanner = _context.EventPlanner
            .Include(est => est.Concerts)
            .FirstOrDefault(est => est.Id == id);

            if (EventPlanner == null) {
            return NotFound();
            }
                                  
        return Page();
        }
    }
}