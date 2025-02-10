using System.Collections.Generic;
using Microsoft.Win32;

namespace T4EX
{
    public class EX18
    {
        public static void Done()
        {
            const string AskNum = "Type a number. All the elmenets above It will be deleted from the list:";
            int num;

            List<int> listNums = new List<int>()
            {
                1,
                3,
                5,
                34,
                15,
                83,
                144,
                123,
                55
            };

            Console.WriteLine(string.Join(" / ", listNums));
            num = Ask.GetIntInput(AskNum);
            listNums.RemoveAll(n => n > num);
            Console.WriteLine(string.Join(" / ", listNums));
        }
    }
}