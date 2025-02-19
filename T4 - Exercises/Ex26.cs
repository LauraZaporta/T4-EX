using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX26
    {
        public static bool ValidateMail(string mail)
        {
            return Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]");
        }
        public static void Done()
        {
            Console.Write("Write your mail: ");
            string result = ValidateMail(Console.ReadLine()) ? "Valid mail" : "Invalid mail";
            Console.WriteLine(result);
        }
    }
}