using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertCentral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConcertCentral.Pages
{
    public class IndexModel : PageModel
    {
        private AppDbContext _context;
        public int FillingFast;
        public int Metallica;

        public int ACDC;

        public int AffordableConcerts;

        public IndexModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            FillingFast = _context.Concert
                            .Where(x => x.SeatsAvailable <100)
                            .Count();    

            Metallica    = _context.Concert
                            .Where(x => x.Band.Name == "Metallica" && x.ConcertDate>DateTime.Today)
                            .Count();          

            ACDC   = _context.Concert
                            .Where(x => x.Band.Name == "AC DC" && x.ConcertDate>DateTime.Today)
                            .Count(); 

            AffordableConcerts = _context.Concert
                            .Where(x => x.MaxPrice < 200)
                            .Count();                


        }
    }
}
