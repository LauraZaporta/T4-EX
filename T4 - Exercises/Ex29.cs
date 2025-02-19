
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX29
    {
        public static bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                return true;
            } 
            return false;
        }

        public static void Done()
        {
            Console.WriteLine(ValidatePassword("Hola1234!")); //True
            Console.WriteLine(ValidatePassword("Hola1234")); //False
            Console.WriteLine(ValidatePassword("Hola12$")); //False
        }
    }
}