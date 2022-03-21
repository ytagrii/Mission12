using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int BookingId { get; set; }
        public int? SignupId { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int TourSlot { get; set; } // numbered 1-12
    }
}
