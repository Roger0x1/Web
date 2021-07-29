using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class SalaryHistory
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Effective Date")]
        [DataType(DataType.Date)]
        public DateTime EffectiveDate { get; set; }

        [Display(Name = "Salary")]
        public double Salary { get; set; }

        [Display(Name = "Salary Type")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string SalaryType { get; set; }

        [Display(Name = "Pay Frequency")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string PayFrequency { get; set; }

        [Display(Name = "Annual Benefit Base Rate")]
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string AnnualBenefitBaseRate { get; set; }


        public string Note { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
    }
}
