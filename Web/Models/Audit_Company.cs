using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Models
{
    public class Audit_Company : IAudit
    {
        [Key]
        public int AuditId { get; set; }
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Name { get; set; }

        public string Note { get; set; }

        [Display(Name = "Is Internal")]
        public bool InternalFlag { get; set; }

        [Display(Name = "Inactive")]
        public bool IsInactive { get; set; }
        public string AuditAction { get; set; }
        public DateTime AuditDate { get; set; }
        public string UserName { get; set; }
    }
}
