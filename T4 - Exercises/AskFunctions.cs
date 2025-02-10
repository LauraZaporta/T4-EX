using System.Globalization;

namespace T4EX
{
    public class Ask
    {
        public static int GetIntInput(string MsgInfo)
        {
            const string MsgError = "Error! Type a valid number (no decimals)";
            bool validInput = false;
            int num = 0;

            do
            {
                Console.Write($"{MsgInfo} ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine(MsgError);
                }
            } while (!validInput);

            return num;
        }
        public static double GetDoubleInput(string MsgInfo)
        {
            const string MsgError = "Error! Type a valid number";
            bool validInput = false;
            double num = 0;

            do
            {
                Console.Write($"{MsgInfo} ");
                string? input = Console.ReadLine();

                if (double.TryParse(input, out num))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine(MsgError);
                }
            } while (!validInput);

            return num;
        }

        public static DateTime GetDateInput(string MsgInfo)
        {
            const string MsgError = "Error! Type a valid date!";
            bool validInput = false;
            DateTime date;

            do
            {
                Console.Write($"{MsgInfo} ");
                string? input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine(MsgError);
                }
            } while (!validInput);

            return date;
        }
    }
}