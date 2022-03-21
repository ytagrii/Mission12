using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface ISignupRepository
    {
        IQueryable<Signup> Signups { get; }
    }
}
