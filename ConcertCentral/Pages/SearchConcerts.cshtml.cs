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
    public class SearchConcertsModel : PageModel
    {   private AppDbContext _context;
        
        public SearchConcertsModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            SearchCompleted = false;
        }


        [BindProperty]
        public string Search { get; set; }
        
        // WE WILL USE THIS PROPERTY TO TRACK IF A SEARCH HAS BEEN PERFORMED
        public bool SearchCompleted { get; set; }
        
        // WE WILL STORE THE RESULTS IN THIS PROPERTY
        public ICollection<Concert> SearchResults { get; set; }
        
        public void OnPost() {
            // PERFORM SEARCH
            if (string.IsNullOrWhiteSpace(Search)) {
                // EXIT EARLY IF THERE IS NO SEARCH TERM PROVIDED
                return;
            }
            SearchResults = _context.Concert
                                    .Include(x => x.Band)
                                    .Where(x => x.Name.ToLower().Contains(Search.ToLower()))
                                    .ToList();
            SearchCompleted = true;
        }
    }
}