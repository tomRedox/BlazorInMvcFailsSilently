using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SSB31Prev2.Data
{
    
    public class MethodErrorService
    {
        public MethodErrorService(ILogger<MethodErrorService> logger)
        {
            logger.LogInformation("Test logging");
        }

        public void DoingSomethingThrowsError()
        {
            
            throw new Exception("Uh oh, method threw an error");
        }
    }
}
