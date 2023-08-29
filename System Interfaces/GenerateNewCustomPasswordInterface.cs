using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro.System_Interfaces
{
    internal class GenerateNewCustomPasswordInterface : BaseInterface
    {
        public static void ShowGenerateNewCustomPasswordInterface()
        {
            do
            {
                Console.Clear();
                int Choices = 0, Length = 0;
                BaseInterface.InterfaceHead("Generate New Custom Password", 75);
                _ReadPasswordConstraints(ref Choices, ref Length);

                if (Length <= 0)
                {
                    Console.WriteLine("\t\t\t\tThe Length Of Your Password Must Be Graeter Than 0 !");
                    Console.ReadKey();
                    continue;
                }

                Password password = new Password(Generator.GeneratePassword(Choices, Length));
                password.Save();

                Console.WriteLine($"\t\t\t\tYour Password : {password.Content}\n\t\t\t\tCharacters Set : " +
                    $"{Password.GetPasswordCharactersSetString(Choices)}\n\t\t\t\t" +
                    $"Length : {Length}\n");
                BaseInterface.InterfaceFooter();
            }
            while (_RegenerateOrGoBackToMainMenue());

            Console.ReadKey();
        }

        private static void _ReadPasswordConstraints(ref int Choices,ref int Length)
        {
            Console.ForegroundColor = BaseInterface.ForeColor;
            _ReadChoice(ref Choices, "\t\t\t\tDo You Need Capetal Letters ?[Yes , No] ", Generator.eCharactersSet.Capital_Letters);
            _ReadChoice(ref Choices, "\t\t\t\tDo You Need Small Letters ?[Yes , No] ", Generator.eCharactersSet.Small_Letters);
            _ReadChoice(ref Choices, "\t\t\t\tDo You Need Digits ?[Yes , No] ", Generator.eCharactersSet.Digits);
            _ReadChoice(ref Choices, "\t\t\t\tDo You Need Special Characters ?[Yes , No] ", Generator.eCharactersSet.SpecialSymbols);

            Console.Write("\t\t\t\tEnter Your Password Length : ");
            Length = InputValidation.ReadIntegerNumber();

            Console.WriteLine();
        }

        private static void _ReadChoice(ref int Choices,string Message,Generator.eCharactersSet Choice)
        {
            Console.Write(Message);
            if (string.Compare(Console.ReadLine(), "yes", true) == 0)
                Choices |= (int)Choice;
            Console.WriteLine();
            return;
        }

        private static bool _RegenerateOrGoBackToMainMenue()
        {
            Console.Write("\t\t\t\tRegenerate Another Password [Yes] , Go Back To Main Menu [Press Any Key] :");
            return string.Compare(Console.ReadLine(), "yes", true) == 0;
        }

    }
}
