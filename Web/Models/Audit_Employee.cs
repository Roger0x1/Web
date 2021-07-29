using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Models
{
    public class Audit_Employee : IAudit
    {
        [Key]
        public int AuditId { get; set; }

        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string LastName { get; set; }

        [MaxLength(3, ErrorMessage = "No more than 3 characters")]
        public string Suffix { get; set; }

        [Display(Name = "Other Name")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string OtherName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

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

        [Display(Name = "Employee Number")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Number { get; set; }
        public string Note { get; set; }             

        public string AuditAction { get; set; }
        public DateTime AuditDate { get; set; }
        public string UserName { get; set; }
    }
}
