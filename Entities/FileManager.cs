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
                using (StreamWriter writer = File.AppendText(FilePath))
                {
                    writer.WriteLine(str);
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception) { return; }
        }

        public static string ReadAllFileContent(string FilePath)
        {
            try
            {
                if (!File.Exists(FilePath))
                    return null;

                using (StreamReader reader = File.OpenText(FilePath))
                {
                    string str = default;
                    str = reader.ReadToEnd();
                    reader.Close();
                    return str;
                }
            }
            catch (Exception) { return null; }  
        }


    }
}
