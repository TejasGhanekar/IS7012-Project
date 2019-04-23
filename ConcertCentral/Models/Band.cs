
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConcertCentral.Models
{
    public class Band
    {
          public static ValidationResult BandNameValidation(string name, ValidationContext context) {
                if (string.IsNullOrWhiteSpace(name)) {
                    return ValidationResult.Success;
                }
                var instance = context.ObjectInstance as Band;
                if (instance == null) {
                    return ValidationResult.Success;
                }
                var dbContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
                int duplicateCount = dbContext.Band
                                  .Count(x => x.Id != instance.Id && x.Name == name);
                if(duplicateCount > 0) {
                return new ValidationResult($"Band - {name} already exists");
             }
            return ValidationResult.Success;
        }

        public static ValidationResult EstablishedInPast(DateTime? EstablishmentDate, ValidationContext context) {
            if (EstablishmentDate == null) {
                return ValidationResult.Success;
            }
           
            if (EstablishmentDate < DateTime.Today) {
                return ValidationResult.Success;
            }

            return new ValidationResult("Establishment date should be in the past");
            
        }

      
        [Key]
        public int Id { get; set; }

        [CustomValidation(typeof(Band), "BandNameValidation")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Established")]
        [CustomValidation(typeof(Band), "EstablishedInPast")]
        [DataType(DataType.Date)]
        public DateTime EstablishmentDate { get; set; }

        [Required]
        public string Genre { get; set; }
        

        [Display(Name="No. Of Members")]
        public int NoOfMembers { get; set; }
        
        public ICollection<Concert> Concerts { get; set; }
        
        // ADD PROPERTIES HERE
    }
}
            