using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen___Pro.Entities
{
    internal class FileManager
    {
        public static string GeneratedPasswordsFilePath 
        { get => @"C:\C#\Password Generator Project\PassGen - Pro\GeneratedPasswordsFile.txt"; }


        public static void SaveToFile(string str, string FilePath)
        {
            try
            {
                StreamWriter writer = File.AppendText(FilePath);
                writer.WriteLine(str);
                writer.Flush();
                writer.Close();
            }
            catch (Exception) { return; }
        }
    }
}
