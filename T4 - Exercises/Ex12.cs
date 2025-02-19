using System.Collections;

namespace T4EX
{
    public class EX12
    {
        public static void Done()
        {
            const string AskDate = "Enter a date (dd,mm,yyyy):";

            Employee hi = new Employee(Ask.GetDateInput(AskDate));
            Console.WriteLine($"Age: {hi.ExtractAgeFromBirth()}");
        }
    }
}