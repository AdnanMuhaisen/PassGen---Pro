using System;
using System.Text;
using PassGen___Pro.Entities;


namespace PassGen___Pro.System_Interfaces
{
    internal class GeneratedPasswordsInterface
    {
        public static void ShowGeneratedPasswordsInterface()
        {
            BaseInterface.InterfaceHead("All Generated Passwords", color: ConsoleColor.Red,Left: 75);
            string[] GeneratedPasswords = FileManager.ReadAllFileContent(FileManager.GeneratedPasswordsFilePath).Split('\n');
            StringBuilder sb;
            foreach (string str in GeneratedPasswords)
            {
                if (str.Length < 19)
                    continue;

                sb = new StringBuilder(Encryptor.DecryptString(str.Substring(19, str.IndexOf(" ",19))));
                Console.WriteLine($"\t\t\tPassword Content : {sb.ToString()} ,{str.Substring(str.IndexOf(" ", 19))}\n");
            }
            Console.WriteLine($"\t\t\tTotal Number : {GeneratedPasswords.Length}");
            BaseInterface.InterfaceFooter(color: ConsoleColor.Red);
            Console.Write("\t\t\tPress Any Key To Go Back To Main Menue ...");
            Console.ReadKey();
        }
    }
}
