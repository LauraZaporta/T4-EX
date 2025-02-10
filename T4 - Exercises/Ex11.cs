using System.Collections;

namespace T4EX
{
    public class EX11
    {
        public static void Done()
        {
            const string WeekdayInfo = "Today is {0}";

            DateTime ara = DateTime.Now;
            Console.WriteLine(WeekdayInfo, ara.DayOfWeek);
        }
    }
}