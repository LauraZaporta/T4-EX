using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX23
    {
        public delegate int Operacio(int a, int b);
        
        public static void Done()
        {
            Operacio pow = (a, b) => (int)Math.Pow(a, b); //Funcions anònimes sempre al controlador???
            Console.WriteLine(pow(3,3));
        }
    }
}