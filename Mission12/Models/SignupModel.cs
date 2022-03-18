using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class SignupModel
    {
        [Key]
        [Required]
        public int SignupID { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public int TourSlot { get; set; } // numbered 1-12
    }
}
