using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Signup
    {
        [Key]
        [Required]
        public int SignupID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // We probably need to build a new model for these so we can tell how that will all work and stuff
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TourSlot { get; set; } // numbered 1-12
    }
}
