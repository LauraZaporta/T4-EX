using System;
using EX35;
using Newtonsoft.Json;

namespace EX35
{
    public class Program
    {
        public static void Main()
        {
            Llibre TSHOEH = new Llibre { Title = "The Seven Husbands Of Evelyn Hugo", Author = "Taylor", Year = 2018};
            Llibre MCom = new Llibre { Title = "Manifest Comunista", Author = "Marx i Engels", Year = 1848};

            string jsonOne = JsonConvert.SerializeObject(TSHOEH);
            Console.WriteLine(jsonOne);
        }
    }
}