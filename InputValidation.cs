using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro
{
    internal static class InputValidation
    {
        public static bool IsNumberBetween(int Num, int From, int To)
            => ((Num >= From) && (Num <= To));

        public static bool IsIntNumber(string Input)
            => int.TryParse(Input, out int Temp);

        public static int ReadIntegerNumber()
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out int Temp))
                    return Temp;
                else
                    Console.WriteLine("Please Enter A Valid Number !");
            } while (true);
        }
    }
}
