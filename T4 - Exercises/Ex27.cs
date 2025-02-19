using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX27
    {
        public static bool ValidatePhone(string phone)
        {
            bool valid = false;
            if (Regex.IsMatch(phone, @"^[0-9]{9}$"))
            {
                valid = true;
            } else if (Regex.IsMatch(phone, @"^[0-9]{3} [0-9]{3} [0-9]{3}$")){
                valid = true;
            } else if (Regex.IsMatch(phone, @"^[+34] [0-9]{3} [0-9]{3} [0-9]{3}$"))
            {
                valid = true;
            }
            return valid;
        }
        public static void Done()
        {
            Console.Write("Write your phone: ");
            string result = ValidatePhone(Console.ReadLine()) ? "Valid phone" : "Invalid phone";
            Console.WriteLine(result);
        }
    }
}