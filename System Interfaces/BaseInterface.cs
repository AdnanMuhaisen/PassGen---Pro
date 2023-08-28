using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro
{
    internal class BaseInterface
    {
        protected const ConsoleColor ForeColor = ConsoleColor.Green;

        public static void DoubleTab()
        => Console.WriteLine(string.Concat("-------------------------------------------------------------------------".PadLeft(100),
            "\n", "-------------------------------------------------------------------------".PadLeft(100)));

        public static void Tab()
        => Console.WriteLine("-------------------------------------------------------------------------".PadLeft(100));

        public static void InterfaceHead(string Title,int Left = 70)
        {
            Console.ForegroundColor = ForeColor;
            Tab();
            Console.WriteLine(string.Concat("PassGen - Pro".PadLeft(70), "\n",
                Title.PadLeft(Left)));
            Tab();
        }

        public static void InterfaceFooter()
        {
            Console.ForegroundColor = ForeColor;
            Tab();
            Console.WriteLine( "Keep Your Passwords Strog With US :)".PadLeft(85));
            Console.WriteLine("PassGen - Pro".PadLeft(70));
            Tab();
        }
    }
}
