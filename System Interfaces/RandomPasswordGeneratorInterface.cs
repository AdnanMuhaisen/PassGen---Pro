﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro.System_Interfaces
{
    internal class RandomPasswordGeneratorInterface : BaseInterface
    {
        public static void ShowRandomPasswordGeneratorInterface()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = BaseInterface.ForeColor;
                BaseInterface.InterfaceHead("Generate_A_New_Random_Password_With_Random_Length", 85);
                int Length = new Random().Next(8, 16);

                string CharactersSetContent = "";
                int CharactersSet = Generator.GenerateRandomCharactersSet(ref CharactersSetContent);

                Password password =
                    new Password(Generator.GeneratePassword(CharactersSet, Length));
                Console.WriteLine($"\t\t\t\tYour Password Is : {password.Content}\n" +
                    $"\t\t\t\tCharacters Set : {CharactersSetContent}\n\t\t\t\tLength : {Length}");
                password.Save();

                BaseInterface.InterfaceFooter();
            } while (_RegenerateOrGoBackToMainMenue());

            Console.ReadKey();
        }

        private static bool _RegenerateOrGoBackToMainMenue()
        {
            Console.Write("\t\t\t\tRegenerate Another Password [Yes] , Go Back To Main Menu [Press Any Key] :");
            return string.Compare(Console.ReadLine(), "yes", true) == 0;
        }
    }
}
