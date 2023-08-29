using PassGen___Pro.System_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro
{
    internal class MainMenuInterface : BaseInterface
    {
        private const int FirstMenuOptionsIndex = 1;
        private const int LastMenuOptionsIndex = 4;

        public enum eMainMenuOptions
        {
            Generate_A_New_Random_Password_With_Random_Length = 1,
            Generate_A_New_Custom_Password,
            Show_Characters_Sets,
            Display_Generated_Passwords
        }

        private static int _GetUserChoice()
        {
            do
            {
                Console.Write("\t\t\t\tPress Your Choice Number Please : ");
                string Input = Console.ReadLine();

                if (InputValidation.IsIntNumber(Input))
                {
                    int InputNumber = Convert.ToInt32(Input);
                    if (InputValidation.IsNumberBetween(InputNumber, FirstMenuOptionsIndex, LastMenuOptionsIndex))
                        return InputNumber;
                    else
                        Console.WriteLine($"\t\t\t\tPlease Enter A Valid Choice Index [{FirstMenuOptionsIndex} , {LastMenuOptionsIndex} ]\n");
                }
                else
                    Console.WriteLine($"\t\t\t\tPlease Enter A Valid Number !\n");

            } while (true);
        }

        public static void ShowMainMenuInterface()
        {
            BaseInterface.InterfaceHead("Main Menue");

            Console.ForegroundColor = BaseInterface.ForeColor;
            Console.WriteLine("\n\t\t\t\t" + $"[1] {eMainMenuOptions.Generate_A_New_Random_Password_With_Random_Length}");
            Console.WriteLine($"\t\t\t\t[2] {eMainMenuOptions.Generate_A_New_Custom_Password}");
            Console.WriteLine($"\t\t\t\t[3] {eMainMenuOptions.Show_Characters_Sets}");
            Console.WriteLine($"\t\t\t\t[4] {eMainMenuOptions.Display_Generated_Passwords}" + "\n\n");

            BaseInterface.InterfaceFooter();
            _PerformMenuOption((eMainMenuOptions)_GetUserChoice());
        }

        private static void _PerformMenuOption(eMainMenuOptions Option)
        {
            switch (Option)
            {
                case eMainMenuOptions.Generate_A_New_Random_Password_With_Random_Length:
                    Console.Clear();
                    RandomPasswordGeneratorInterface.ShowRandomPasswordGeneratorInterface();
                    GoBackToMainMenue();
                    break;
                case eMainMenuOptions.Generate_A_New_Custom_Password:
                    Console.Clear();
                    GenerateNewCustomPasswordInterface.ShowGenerateNewCustomPasswordInterface();
                    GoBackToMainMenue();
                    break;
                case eMainMenuOptions.Show_Characters_Sets:
                    Console.Clear();
                    CharactersSetInterface.ShowCharactersSetInterface();
                    GoBackToMainMenue();
                    break;
                case eMainMenuOptions.Display_Generated_Passwords:
                    Console.Clear();
                    GeneratedPasswordsInterface.ShowGeneratedPasswordsInterface();
                    GoBackToMainMenue();
                    break;
            }
        }

        protected static void GoBackToMainMenue()
        {
            Console.Clear();
            Console.ForegroundColor= BaseInterface.ForeColor;
            ShowMainMenuInterface();
        }
    }
}
