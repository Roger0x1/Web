using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class OnboardingItem
    {
        [Key]
        public int Id { get; set; }
        public int BarPosition { get; set; }                        //  Associates this item to one of the position balls

        [MaxLength(20, ErrorMessage = "20 Characters max")]
        public string Title { get; set; }                           //  The name that displays in the list of items under the position ball
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDateForItem { get; set; } = null;     //  the DateTime that the item is started or updated: default is null, when the status changes to submitted, this is set.
        public string Status { get; set; }                          //  Status:  Not started, Submitted, Recieved, Complete
        public string Result { get; set; }                          //  Result: Ok, Warning, Fail


        public bool IsSelected { get; set; } = true;                // Drives the inclusion of the item for an individual

        public int TimeDelta
        {
            get
            {
                if (this.StartDateForItem == null) return 0;
                else
                {
                    return DateTime.Today.Subtract((DateTime)this.StartDateForItem).Days;
                }
            }
        }

        [ForeignKey("EmployeeId")]
        public int? EmployeeId { get; set; }                        // Needs to be nullable so we can get the default list for assignment

    }
}
