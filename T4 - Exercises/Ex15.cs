namespace T4EX
{
    public class EX15
    {
        public static void Done()
        {
            List<int> list = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };
            Console.WriteLine(string.Join(" / ", list.Where(n => n%2 == 0)));
        }
    }
}