using System.Collections.Generic;

namespace T4EX
{
    public class EX16
    {
        public static void Done()
        {
            string[] array = new string[5] { "Hola", "El", "Determinisme", "És", "Real"};
            Console.WriteLine(string.Join(" / ", (array.ToList())));
        }
    }
}