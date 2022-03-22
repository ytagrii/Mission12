using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission12.Models
{
    public class EFSignupRepository : ISignupRepository
    {
        private SignupContext context { get; set; }

        public EFSignupRepository(SignupContext temp)
        {
            context = temp;
        }
        public IQueryable<Signup> Signups => context.Signups;

        public void Save(Signup s)
        {
            context.Add(s);
            context.SaveChanges();
        }

        public void Edit(Signup s)
        {
            context.Update(s);
            context.SaveChanges();
        }
        public void Delete(Signup s)
        {
            context.Remove(s);
            context.SaveChanges();
        }
        public List<Signup> GetAll()
        {
            var signups = context.Signups.Include(x => x.Appointment.Date).ToList();
            return signups;
        }
    }
}
