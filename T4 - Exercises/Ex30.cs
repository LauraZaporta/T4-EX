using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX30
    {
        public static bool ValidateCodiPostal(string password)
        {
            if (Regex.IsMatch(password, @"^[0-5]{1}[1-9]{1}[0-9]{3}$"))
            {
                return true;
            }
            return false;
        }

        public static void Done()
        {
            Console.WriteLine(ValidateCodiPostal("08001")); //True
            Console.WriteLine(ValidateCodiPostal("60000")); //False
        }
    }
}