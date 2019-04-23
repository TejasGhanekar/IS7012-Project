
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConcertCentral.Models
{
    public class Concert
    {
          public static ValidationResult SeatsAvailabilityCheck(int? SeatsAvailable,ValidationContext context) {
            if (SeatsAvailable == null) {
                return ValidationResult.Success;
            }
            var instance = context.ObjectInstance as Concert;
           
            if (SeatsAvailable >= 0 && instance.ConcertDate>DateTime.Today) {
                return ValidationResult.Success;
            }

            if (SeatsAvailable == 0 && instance.ConcertDate<DateTime.Today) {
                return ValidationResult.Success;
            }

            return new ValidationResult("Seats Available must be 0");
            
            
        }    

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Venue { get; set; }

        [Display(Name="Concert Date")]
        public DateTime ConcertDate { get; set; }

        [Display(Name="Parking Availability")]
        public bool ParkingAvailability { get; set; }

        [Display(Name="Minimum Ticket Price")]
        public decimal MinPrice { get; set; }

        [Display(Name="Maximum Ticket Price")]
        public decimal MaxPrice { get; set; }

        [CustomValidation(typeof(Concert), "SeatsAvailabilityCheck")]
        [Display(Name="Seats Available")]
        public int SeatsAvailable { get; set; }

        //ADD Properties
        [Display(Name="Band")]
        public int BandId { get; set; }
        public Band Band {get; set;}
        
        
        [Display(Name="Event Planner")]
        public int EventPlannerId { get; set; }

        [Display(Name="Event Planner")]
        public EventPlanner EventPlanner {get; set;}

         public string IsParkingAvailable 
        {
             get
             {
                 if(ParkingAvailability)
                 {return "Available";}
                 else{
                     return "Not Available";
                 }
             } 
        }

        public string SeatStatus 
        {
             get
             {
                if(SeatsAvailable==0){
                     return "Sold Out";
                }
                else if(SeatsAvailable>0 && SeatsAvailable<100){
                    return "Filling Fast";
                }else{
                    return "Grab them now!";

                }
             } 
        }



        
        // ADD PROPERTIES HERE
    }
}
            