using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX19
    {
        public delegate int Operacio(int numOne, int numTwo);
        public static int Multiplicar(int a, int b) { return a * b; }
        public static int Dividir(int a, int b) { return a / b; }
        public static void Done()
        {
            Operacio delegat = Multiplicar;
            Console.WriteLine(delegat(6,7));
            delegat = Dividir;
            Console.WriteLine(delegat(42, 7));
        }
    }
}