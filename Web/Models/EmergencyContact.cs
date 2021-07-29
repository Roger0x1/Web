using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class EmergencyContact : Person
    {
        [Display(Name = "Contact Priority")]
        public string ContactPriority { get; set; }

        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Relationship { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

    }
}
