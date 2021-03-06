using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Uppgift9
{
    public class SwedishID : IdNumber
    {
        public SwedishID()
        {

        }
        public bool CheckIfValid(long number)
        {
            List<int> numbers = number.SelectEachNumber().ToList();
            if (numbers.Count() == 12)
            {
                var shortNumber = numbers.Skip(2).ToList();
                numbers = shortNumber;
            }
            var controlNumberGiven = numbers[^1];

            List<int> LuhnProducts = new List<int>();
            long product;
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                product = (Math.Pow(-1, i) == 1) ? 2 * numbers[i] : numbers[i];
                foreach (var num in product.SelectEachNumber())
                {
                    LuhnProducts.Add(num);
                }
            }
            var luhnSum = LuhnProducts.Sum();
            var controlNumber = 10 - luhnSum % 10;

            return controlNumber == controlNumberGiven;
        }
    }
}
