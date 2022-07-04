using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.Infrastructure.Utilities.Generator
{
    public static class Generator
    {
        public static int UniqueNumberGenerator()
        {
            Random rnd = new Random();
            var number = rnd.Next(1111111, 9999999);
            return number;
        }

        public static string UniqueTraceCodeGenerator()
        {
            return Guid.NewGuid()
                .ToString()
                .Replace("-", "");
        }
    }
}
