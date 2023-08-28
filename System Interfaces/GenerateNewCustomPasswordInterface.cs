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
            int Choices = 0, Length = 0;
            BaseInterface.InterfaceHead("Generate New Custom Password",75);
            _ReadPasswordConstraints(ref Choices, ref Length);

            Password password = new Password(Generator.GeneratePassword(Choices, Length));
            password.Save();

            Console.WriteLine($"\t\t\t\tYour Password : {password.Content}\n\t\t\t\tCharacters Set : " +
                $"{Password.GetPasswordCharactersSetString(Choices)}\n\t\t\t\t" +
                $"Length : {Length}\n");
            BaseInterface.InterfaceFooter();
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

    }
}
