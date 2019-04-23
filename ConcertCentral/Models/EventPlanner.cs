
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConcertCentral.Models
{
    public class EventPlanner
    {
        public static ValidationResult EventPlannerNameValidation(string name, ValidationContext context) {
                if (string.IsNullOrWhiteSpace(name)) {
                    return ValidationResult.Success;
                }
                var instance = context.ObjectInstance as EventPlanner;
                if (instance == null) {
                    return ValidationResult.Success;
                }
                var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
                int duplicateCount = dbContext.EventPlanner
                                  .Count(x => x.Id != instance.Id && x.Name == name);
                if(duplicateCount > 0) {
                return new ValidationResult($"Event planner - {name} already exists");
             }
            return ValidationResult.Success;
        }

        
        [Key]

        public int Id { get; set; }

        [Required]
        [CustomValidation(typeof(EventPlanner), "EventPlannerNameValidation")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Street Address 1")]
        public string StreetAddressOne { get; set; }

        [Display(Name="Street Address 2")]
        public string StreetAddressTwo { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Display(Name="Contact Number")]
        public string ContactNumber { get; set; }

        public ICollection<Concert> Concerts { get; set; }

         public string FullAddress
        {
             get
             {
                 string Address;
                 Address = StreetAddressOne+" "+StreetAddressTwo+" "+City+" "+State+" "+Zip;
                 return Address;

             } 
        }

        
        
        // ADD PROPERTIES HERE
    }
}
            