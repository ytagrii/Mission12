using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface ISignupRepository
    {
        IQueryable<Signup> Signups { get; }

        public void Save(Signup s)
        {

        }
        public void Edit(Signup s)
        {

        }
        public void Delete(Signup s)
        {

        }
        
    }
}
