using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFSignupRepository : ISignupRepository
    {
        private SignupContext context;

        public EFSignupRepository(SignupContext temp)
        {
            context = temp;
        }
        public IQueryable<Signup> Signups => context.Signups;
    }
}
