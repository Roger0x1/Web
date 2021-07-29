using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public abstract class Person
    {
        [Key]
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
    }
}