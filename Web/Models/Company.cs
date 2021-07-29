using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Name { get; set; }


        public string Note { get; set; }

        [Display(Name = "Is Internal")]
        public bool InternalFlag { get; set; }

        [Display(Name = "Inactive")]
        public bool IsInactive { get; set; }
    }
}
