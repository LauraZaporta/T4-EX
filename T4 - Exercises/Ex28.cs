using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace T4EX
{
    public class EX28
    {
        public static string ExtractNumbers(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: [");
            int currentIndex = 0;
            int handleOutOfBounds = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.IsMatch(text[i].ToString(), @"[0-9]"))
                {
                    currentIndex = i;
                    do
                    {
                        if (currentIndex <= text.Length - 1)
                        {
                            sb.Append(text[currentIndex]);
                            currentIndex++;
                            handleOutOfBounds = (currentIndex > (text.Length - 1)) ? currentIndex - 1 : currentIndex;
                        }
                    } while (Regex.IsMatch(text[handleOutOfBounds].ToString(), @"[0-9]") && currentIndex <= (text.Length-1));
                    if (handleOutOfBounds == currentIndex)
                    {
                        sb.Append(", ");
                    }
                    i = currentIndex;
                }
            }
            sb.Append("]");
            return sb.ToString();
        }
        public static void Done()
        {
            string text = "Avui és el dia 12 del mes 02 de l'any 2024";
            string result = ExtractNumbers(text);
            Console.WriteLine(result);
        }
    }
}