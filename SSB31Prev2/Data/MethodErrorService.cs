using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSB31Prev2.Data
{
    public class MethodErrorService
    {
        public void DoingSomethingThrowsError()
        {
            throw new Exception("Uh oh, method threw an error");
        }
    }
}
