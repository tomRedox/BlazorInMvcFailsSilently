using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSB31Prev2.Data
{
    public class ConstructorErrorService
    {
        public ConstructorErrorService()
        {
            throw new Exception("Oh no, a constructor error");
        }
    }
}
