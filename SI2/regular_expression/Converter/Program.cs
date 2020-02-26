using System;
using System.IO;
using System.Text;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            var sr = new StreamReader("D:/CC_C#_branch/C-_SI_assingments/SI2/regular_expression/Converter/file.txt", true);
            text = sr.ReadToEnd();
            sr.Close();
            Encoding e = Encoding.UTF7;
            byte[] encoded = e.GetBytes(text);
            File.WriteAllBytes("D:/CC_C#_branch/C-_SI_assingments/SI2/regular_expression/Converter/file.txt", encoded);
        }
    }
}
