using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX21
    {
        public delegate void Notificacio(string missaatge);
        public static void ShowMessage(string missatge)
        {
            Console.WriteLine(missatge);
        }
        public static void ShowMessageWithStars(string missatge)
        {
            Console.WriteLine("*** " + missatge + " ***");
        }
        public static void Done()
        {
            Notificacio printPantalla = ShowMessage;
            printPantalla += ShowMessageWithStars;

            printPantalla("ATLAIMYCBT");
        }
    }
}