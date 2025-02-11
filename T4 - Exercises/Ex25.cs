using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX25
    {
        public static void ExecutarAmbAAnonimusMethod(Action<string> print, string msg)
        {
            print(msg);
        }
        public static void Done()
        {
            //Tipus de lamabda, nom, arguments i operació
            Func<int, int, int> Suma = (a, b) => a + b;
            Func<int, int, int> Resta = (a, b) => a - b;

            Console.WriteLine(Suma(3,5));
            Console.WriteLine(Resta(3,5));
        }
    }
}