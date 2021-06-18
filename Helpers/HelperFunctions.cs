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
        private static Random random = new Random();
        public static SkipAndTakeRP ValidateAndCorrectSkipAndTake(SkipAndTakeRP skipAndTakeRP)
        {
            if (skipAndTakeRP.Take > 100) skipAndTakeRP.Take = 100;
            if (skipAndTakeRP.Take == 0) skipAndTakeRP.Take = 10;
            return skipAndTakeRP;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
