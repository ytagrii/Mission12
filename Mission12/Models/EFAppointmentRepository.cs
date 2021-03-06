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

        public void UpdateApp(Appointment a, bool x)
        {
            context.Update(a);
            context.SaveChanges();
        }
        public void NewApp(DateTime d)
        {
            Appointment app = new Appointment();
            app.Date = d;
            context.Add(app);
            context.SaveChanges();
        }
        public void DeleteApp(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }
    }
}
