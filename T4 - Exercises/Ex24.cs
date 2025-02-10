using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX24
    {
        public static void ExecutarAmbAAnonimusMethod(Action<string> print, string msg)
        {
            print(msg);
        }
        public static void PrintMessage(string msg) { Console.WriteLine(msg); }
        public static void Done()
        {
            ExecutarAmbAAnonimusMethod(PrintMessage, "AAAAAAAAAAA");
            ExecutarAmbAAnonimusMethod(PrintMessage, "Pernil");
        }
    }
}