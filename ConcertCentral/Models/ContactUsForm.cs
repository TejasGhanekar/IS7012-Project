using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConcertCentral.Models
{
    public class ContactUsForm
     {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name="Your Message")]
        public string Comments { get; set; }

    }
}