using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX31
    {
        public static void Main()
        {
            List<int> nums = new List<int> { 5, 2, -3, -340, 15, 6, -71, 83, 92, 6 };
            //a
            var queryEven = nums.Where(x => x % 2 == 0);
            Console.Write("Even numbers: ");
            foreach (var num in queryEven) Console.Write(num + " ");
            Console.WriteLine();

            //b
            var queryPositive = nums.Where(x => x > 0);
            Console.Write("Positive numbers: ");
            foreach (var num in queryPositive) Console.Write(num + " ");
            Console.WriteLine();

            //c
            var biggerTwenty = nums.Where(x => x > 20);
            var mapSquared = biggerTwenty.Select(x => x * x);
            Console.Write("Squared numbers: ");
            foreach (var num in mapSquared) Console.Write(num + " ");
            Console.WriteLine();

            //d
            var freq = nums.GroupBy(n => n)
                .Select(num => new
                {
                    Number = num.Key,
                    Freq = num.Count()
                });
            foreach (var num in freq) Console.WriteLine(num + " ");
            Console.WriteLine();

            //e
            string marxQuote = "Workers of the world unite; you have nothing to lose but your chains";
            marxQuote = marxQuote.ToLower();
            var freqCharacters = marxQuote.GroupBy(c => c)
                .Select(letter => new
                {
                    Letter = letter.Key,
                    Freq = letter.Count()
                });
            foreach (var letter in freqCharacters) Console.WriteLine(letter + " ");
            Console.WriteLine();

            //f
            

            //g
            var freqAndMulti = nums.GroupBy(n => n)
                .Select(num => new
                {
                    Number = num.Key,
                    Freq = num.Count(),
                    Multi = num.Count() * num.Key
                });
            foreach (var num in freqAndMulti) Console.WriteLine(num + " ");
            Console.WriteLine();
        }
    }
}