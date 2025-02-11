using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX24
    {
        public delegate void Notificacio(string missatge);
        public static void ExecutarAmbMetodeAnonim(Notificacio notificacio) { notificacio("HOLA"); }
        public static void Main()
        {
            ExecutarAmbMetodeAnonim(delegate (string missatge)
            {
                Console.WriteLine($"[Missatge]: {missatge}");

            });
        }
    }
}