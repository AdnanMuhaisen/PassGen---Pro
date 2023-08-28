using PassGen___Pro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PassGen___Pro.Generator;

namespace PassGen___Pro.System_Interfaces
{
    internal class Password
    {
        public string Content { set; get; }

        public Password(string content)
           => Content = content;

        public void Save()
           => FileManager.SaveToFile($"Password Content : {Encryptor.EncryptString(this.Content)} ,Created At {DateTime.Now}",
                FileManager.GeneratedPasswordsFilePath);

        public static string GetPasswordCharactersSetString(int Set)
        {
            if ((Set & (int)eCharactersSet.All) == (int)eCharactersSet.All)
                return eCharactersSet.All.ToString();

            StringBuilder str = new StringBuilder();
            if ((Set & (int)eCharactersSet.Small_Letters) == (int)eCharactersSet.Small_Letters)
                str.Append(eCharactersSet.Small_Letters.ToString() + " ,");

            if ((Set & (int)eCharactersSet.Capital_Letters) == (int)eCharactersSet.Capital_Letters)
                str.Append(eCharactersSet.Capital_Letters.ToString() + " ,");

            if ((Set & (int)eCharactersSet.Digits) == (int)eCharactersSet.Digits)
                str.Append(eCharactersSet.Digits.ToString() + " ,");

            if ((Set & (int)eCharactersSet.SpecialSymbols) == (int)eCharactersSet.SpecialSymbols)
                str.Append(eCharactersSet.SpecialSymbols.ToString() + " ");

            return str.ToString();
        }
    }
}
