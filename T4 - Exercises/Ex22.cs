using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace T4EX
{
    public class EX22
    {
        public static int Operation(Func<int, int, int> op, int a, int b) { return op(a, b); }
        public static void OperationAction(Action<int, int> op, int a, int b) { op(a, b); }
        public static int Multiplication(int a, int b) { return a * b; }
        public static void Suma (int a, int b) { Console.WriteLine(a + b); }
        public static void Done()
        {
            Console.WriteLine(Operation(Multiplication, 1, 2));
            OperationAction(Suma, 1, 2);
        }
    }
}