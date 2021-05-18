using System;

namespace Uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID number (yyMMddXXXX or yyyyMMddXXXX), '-' is allowed.");
            var idNumberUserInput = Console.ReadLine()
                                           .Replace("-", "");
            var id = new SwedishID();
            var isValid = false;
            if (long.TryParse(idNumberUserInput, out long input))
            {
                isValid = id.CheckIfValid(input);
                if (isValid)
                {
                    Console.WriteLine("Yeah, that's a real personnummer");
                }
                else
                {
                    Console.WriteLine("Nope, not a valid personnummer");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
