using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class SignupContext : DbContext
    {
        public SignupContext()
        {
        }

        public SignupContext(DbContextOptions<SignupContext> options)
            : base(options)
        {
        }

        public DbSet<Signup> Signups { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        
    }
}
