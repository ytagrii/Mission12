using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Signup
    {
        [Key]
        [Required]
        public int SignupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

    }
}
