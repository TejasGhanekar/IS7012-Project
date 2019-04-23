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
    public class UpdateTicketPriceModel : PageModel
    {
        
        private readonly AppDbContext _context;
        public UpdateTicketPriceModel(AppDbContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public ChangeTicketPrice  ChangeTicketPrice { get; set; }
        
        public Concert Concert { get; set; }
        
        
                public IActionResult OnGet(int? id){
                    
                    if (id == null) {
                    return NotFound();
                    }       
            
                    Concert = _context.Concert.Find(id);
            
                    if (Concert == null) {
                    return NotFound();
                    }
            
                    ChangeTicketPrice = new ChangeTicketPrice();
                    ChangeTicketPrice.ConcertId = Concert.Id;
                    return Page();  
                }
                    
                public IActionResult OnPost() {
                    Concert = _context.Concert.Find(ChangeTicketPrice.ConcertId);
            
                    if (!ModelState.IsValid) {
                    return Page();
                    }
            
                    // UPDATE THE AGENT RETRIEVED FROM THE DATABASE
                    Concert.MinPrice = ChangeTicketPrice.NewMinPrice;
                    Concert.MaxPrice = ChangeTicketPrice.NewMaxPrice;;
                    // TELL THE DATABASE TO SAVE WHATEVER CHANGES WE MADE
                     _context.SaveChanges();
                    return RedirectToPage("/concerts/Details", new  { id = Concert.Id });  
                }               

        
    }
}