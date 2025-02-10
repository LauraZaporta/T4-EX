using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX20
    {
        public delegate int Operacio(int numOne, int numTwo);
        public static int ExecutarOperacio(int a, int b, Operacio operacio)
        {
            return operacio(a, b);
        }
        public static int Sumar(int a, int b) => a + b;
        public static int Restar(int a, int b) => a - b;
        public static void Done()
        {
            Console.WriteLine("Suma: {0}", ExecutarOperacio(3,4,Sumar));
            Console.WriteLine("Resta: {0}", ExecutarOperacio(3, 4, Restar));
        }
    }
}