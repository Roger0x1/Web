using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    [Owned]
    public class Address
    {
        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string Street { get; set; }

        [MaxLength(30, ErrorMessage = "No more than 30 characters")]
        public string City { get; set; }

        [MaxLength(2)]
        public string State { get; set; }
        [Display(Name = "Zip Code")]

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
    }
}

