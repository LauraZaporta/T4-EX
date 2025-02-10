using System.Collections;

namespace T4EX
{
    public class EX10
    {
        public static void Done()
        {
            const string AskDate = "Enter a date (dd,mm,yyyy):";

            int outputCompare;
            DateTime dateOne, dateTwo;

            dateOne = Ask.GetDateInput(AskDate);
            dateTwo = Ask.GetDateInput(AskDate);

            outputCompare = DateTime.Compare(dateOne, dateTwo);

            if (outputCompare == -1) { Console.WriteLine("The first date happened before the second!"); }
            else if (outputCompare == 0){ Console.WriteLine("These are the same date!"); }
            else { Console.WriteLine("The first date happened after the second!"); }
        }
    }
}