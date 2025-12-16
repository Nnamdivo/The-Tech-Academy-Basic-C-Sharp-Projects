using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public partial class Insuree
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [StringLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Car Year")]
        [Range(1900, 2100, ErrorMessage = "Please enter a valid year")]
        public int CarYear { get; set; }

        [Required]
        [Display(Name = "Car Make")]
        [StringLength(50)]
        public string CarMake { get; set; }

        [Required]
        [Display(Name = "Car Model")]
        [StringLength(50)]
        public string CarModel { get; set; }

        [Display(Name = "DUI")]
        public bool DUI { get; set; }

        [Required]
        [Display(Name = "Speeding Tickets")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of speeding tickets cannot be negative")]
        public int SpeedingTickets { get; set; }

        [Required]
        [Display(Name = "Coverage Type")]
        [StringLength(50)]
        public string CoverageType { get; set; }

        [Required]
        [Display(Name = "Quote")]
        [DataType(DataType.Currency)]
        public decimal Quote { get; set; }
    }
}

