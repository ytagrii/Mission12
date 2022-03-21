using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFAppointmentRepository : IAppointmentRepository 
    {
        private SignupContext context { get; set; }

        public EFAppointmentRepository(SignupContext temp)
        {
            context = temp;
        }
        public IQueryable<Appointment> Appointments => context.Appointments;
    }
}
