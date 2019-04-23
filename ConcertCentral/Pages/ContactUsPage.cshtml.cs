using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertCentral.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConcertCentral.Pages
{
    public class ContactUsPageModel : PageModel
    {
        private readonly AppDbContext _context;
        public ContactUsPageModel(AppDbContext context)
        {
            _context = context;
        }
        
      //  public ContactUs ContactUs { get; set; }

        [BindProperty]
        public ContactUsForm ContactUsForm { get; set; }

        public bool RecordSaved {get; set;}
        public void OnGet()
        {
            RecordSaved=false;
        }

        public void OnPost() {
            
            // UPDATE THE AGENT RETRIEVED FROM THE DATABASE
            
            // ContactUs.Name = ContactUs.Name;
            // ContactUs.Email = ContactUs.Email;
            // ContactUs.Comments = ContactUs.Comments;
            // TELL THE DATABASE TO SAVE WHATEVER CHANGES WE MADE
            ContactUsForm contactUsForm = ContactUsForm;
            _context.Add(contactUsForm);
            _context.SaveChanges();
            RecordSaved=true;
           // return RedirectToPage("/contactUsPage");
        }
    }
}