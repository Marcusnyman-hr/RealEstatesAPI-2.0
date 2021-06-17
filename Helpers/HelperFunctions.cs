using Helpers.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class HelperFunctions
    {
        public static SkipAndTakeRP ValidateAndCorrectSkipAndTake(SkipAndTakeRP skipAndTakeRP)
        {
            if (skipAndTakeRP.Take > 100) skipAndTakeRP.Take = 100;
            if (skipAndTakeRP.Take == 0) skipAndTakeRP.Take = 10;
            return skipAndTakeRP;
        }
    }
}
