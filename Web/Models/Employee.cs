using Audit.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Employee : Person
    {
        [Required]
        [Display(Name = "Social Security Number")]
        public string SSN { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }


        [Display(Name = "Hire Source")]
        public string HireSource { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Termination Date")]
        [DataType(DataType.Date)]
        public DateTime? TerminationDate { get; set; }    // probably nullable, because if you are working, you are not terminated ...

        [Range(1, 999)]
        [MaxLength(3, ErrorMessage = ("No more than three numbers please"))]
        public string Weight { get; set; }

        [Range(1, 999)]
        [MaxLength(3, ErrorMessage = ("No more than three numbers please"))]
        //  what is/are the units here?
        public string Height { get; set; }

        //  possible drop down for eye color
        [Display(Name = "Eye Color")]
        public string EyeColor { get; set; }

        //  possible drop down for hair color
        [Display(Name = "Hair Color")]
        public string HairColor { get; set; }

        // dropdown for Gender 
        public string Gender { get; set; }

        // dropdown for Race
        public string Race { get; set; }

        [Display(Name = "Birth Place")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Birthplace { get; set; }

        // dropdown for County?
        [Display(Name = "County Citizenship")]
        public string CountyCitizenship { get; set; }


        // dropdown for State
        [Display(Name = "Drivers License State")]
        public string DriversLicenseState { get; set; }

        [Display(Name = "Expiration")]
        [DataType(DataType.Date)]
        public DateTime? DriversLicenseExpiration { get; set; }

        [Display(Name = "Has Card")]
        public bool HasSSCard { get; set; }

        [Display(Name = "Passport Number")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string PassportNumber { get; set; }

        [Display(Name = "Citizenship Status")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string CitizenshipStatus { get; set; }
        [AuditIgnore]
        [Display(Name = "Home Address")]
        public Address HomeAddress { get; set; }
        [AuditIgnore]
        [Display(Name = "Mailing Address")]
        public Address MailingAddress { get; set; }

        [Display(Name = "Employee Number")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        // Is there an existing format for Employee Number?
        public string Number { get; set; }

        public string Note { get; set; }

        [AuditIgnore]
        public string FullName => $"{FirstName} {LastName}";

        [AuditIgnore]
        public List<EmergencyContact> EmergencyContacts { get; set; }

        [AuditIgnore]
        public List<OnboardingItem> onboardingItems { get; set; }

        [AuditIgnore]
        public List<SalaryHistory> salaryHistory { get; set; }

        [AuditIgnore]
        public List<Placement> placements { get; set; }

    }
}
