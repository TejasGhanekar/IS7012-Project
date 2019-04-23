using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConcertCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcertCentral.Pages
{
    public class UpcomingConcertsModel : PageModel
    {
        private AppDbContext _context;

        public UpcomingConcertsModel(AppDbContext context) {
            _context = context;
        }
        public List<Concert> Concerts { get; set; }
        public void OnGet()
        {
            Concerts = _context.Concert
                                    .Include(x => x.Band)
                                    .OrderBy(x => x.ConcertDate).ToList();
        }
    }
}