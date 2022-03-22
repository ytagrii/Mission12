using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        public void UpdateApp(Appointment a, bool x)
        {

        }
        public void NewApp(DateTime d)
        {

        }
        public void DeleteApp(Appointment a)
        {

        }
    }

    
}
