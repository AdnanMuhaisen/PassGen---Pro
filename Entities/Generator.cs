using PassGen___Pro.System_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro
{
    internal class Generator
    {

        [Flags]
        public enum eCharactersSet
        {
            None = 0b_000_0000,
            Capital_Letters = 0b_0000_0001,
            Small_Letters = 0b_000_0010,
            Digits = 0b_000_0100,
            SpecialSymbols = 0b_000_1000,
            All = Capital_Letters | Small_Letters | Digits | SpecialSymbols
        }

        public static string GeneratePassword(int Set, int Length = 8)
        {
            List<short> OptionsList = _GetListOfOptions(Set);
            StringBuilder Sb = new StringBuilder();
            Random Rand = new Random();

            for (int i = 1; i <= Length; i++)
                Sb.Append(GenerateRandomCharacter((eCharactersSet)OptionsList[Rand.Next(0, OptionsList.Count)]));
               
            return Sb.ToString();
        }

        private static char GenerateRandomCharacter(eCharactersSet Option)
        {
            switch (Option)
            {
                case eCharactersSet.Capital_Letters:
                    return (char)new Random().Next(65, 91);

                case eCharactersSet.Small_Letters:
                    return (char)new Random().Next(97, 123);

                case eCharactersSet.Digits:
                    return (char)new Random().Next(48, 58);

                case eCharactersSet.SpecialSymbols:
                    return GenerateSpecialCharacter();
            }
            return '0';
        }

        private static char GenerateSpecialCharacter()
        {
            char[] SpecialCharactersArray = { ':', '.', ';', ',', '@', '#', '!', '?', '$' };
            return SpecialCharactersArray[new Random().Next(0, SpecialCharactersArray.Length)];
        }

        private static List<short> _GetListOfOptions(int SumOfCharactersOptions)
        {
            if ((SumOfCharactersOptions & (int)eCharactersSet.All) == (int)eCharactersSet.All)
                return new List<short>() { 1, 2, 4, 8 };

            List<short> OptionsList = new List<short>();
            if ((SumOfCharactersOptions & (int)eCharactersSet.Small_Letters) == (int)eCharactersSet.Small_Letters)
                OptionsList.Add((int)eCharactersSet.Small_Letters);

            if ((SumOfCharactersOptions & (int)eCharactersSet.Capital_Letters) == (int)eCharactersSet.Capital_Letters)
                OptionsList.Add((int)eCharactersSet.Capital_Letters);

            if ((SumOfCharactersOptions & (int)eCharactersSet.Digits) == (int)eCharactersSet.Digits)
                OptionsList.Add((int)eCharactersSet.Digits);

            if ((SumOfCharactersOptions & (int)eCharactersSet.SpecialSymbols) == (int)eCharactersSet.SpecialSymbols)
                OptionsList.Add((int)eCharactersSet.SpecialSymbols);

            return OptionsList;
        }

        public static int GenerateRandomCharactersSet(ref string SetContent)
        {
            int CharactersSetOption = new Random().Next(1, 16);
            StringBuilder str = new StringBuilder();
            SetContent = Password.GetPasswordCharactersSetString(CharactersSetOption);
            return CharactersSetOption;
        }
    }
}
