using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Dropdown
    {   
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public string DropdownName { get; set; }
        public bool IsInactive { get; set; }
    }
}
