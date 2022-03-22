﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        public int BookingId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
    }
}
