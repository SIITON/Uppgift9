using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uppgift9
{
    public static class Extensions
    {
        public static IEnumerable<int> SelectEachNumber(this long number)
        {
            return number.ToString()
                         .Select(n => int.Parse(n.ToString()));
        }
    }
}
