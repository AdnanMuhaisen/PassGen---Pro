using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro.System_Interfaces
{
    internal class CharactersSetInterface : BaseInterface
    {
        public static void ShowCharactersSetInterface()
        {
            Console.ForegroundColor = BaseInterface.ForeColor;
            BaseInterface.InterfaceHead("Characters Sets");

            Console.WriteLine($"\t\t\t\t\t[1] {Generator.eCharactersSet.Capital_Letters}");
            Console.WriteLine($"\t\t\t\t\t[2] {Generator.eCharactersSet.Small_Letters}");
            Console.WriteLine($"\t\t\t\t\t[3] {Generator.eCharactersSet.Digits}");
            Console.WriteLine($"\t\t\t\t\t[4] {Generator.eCharactersSet.SpecialSymbols}");

            BaseInterface.InterfaceFooter();
            Console.ReadKey();
        }
    }
}
