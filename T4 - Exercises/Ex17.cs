using System.Collections.Generic;
using Microsoft.Win32;

namespace T4EX
{
    public class EX17
    {
        public static void Done()
        {
            Dictionary<string, double> employees = new Dictionary<string, double>();
            employees.Add("Kelta", 0.0);
            employees.Add("Sera", 2000.50);
            employees.Add("Dorian", 1575.83);

            foreach (KeyValuePair<string, double> emp in employees)
            {
                Console.WriteLine("Nom: {0}, Salari: {1}", emp.Key, emp.Value);
            }
        }
    }
}