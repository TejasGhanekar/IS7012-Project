
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConcertCentral.Models
{
    public class ChangeTicketPrice {
        public int ConcertId { get; set; }

        [Display(Name="New Minimum Ticket Price")]
        public decimal NewMinPrice { get; set; }

         [Display(Name="New Maximum Ticket Price")]
        public decimal NewMaxPrice { get; set; }
    }
}