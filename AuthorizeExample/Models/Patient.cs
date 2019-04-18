using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorizeExample.Models
{
    public class Patient
    {
        [Required]
        [Key]
        [StringLength(maximumLength: 128)]
        public string PatientID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string BloodType { get; set; }
    }
}