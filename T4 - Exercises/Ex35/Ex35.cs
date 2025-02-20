using System;
using EX35;
using Newtonsoft.Json;

namespace EX35
{
    public class Program
    {
        public static void Main()
        {
            const string path = @"C:\Users\msi 2.0\Source\Repos\T4-EX\T4 - Exercises\Ex35\llibres.json";

            List<Llibre> nousLlibres = new List<Llibre> {
                new Llibre { Title = "The Seven Husbands Of Evelyn Hugo", Author = "Taylor", Year = 2018},
                new Llibre { Title = "Manifest Comunista", Author = "Marx i Engels", Year = 1848}
            };

            string jsonOne = JsonConvert.SerializeObject(nousLlibres);

            File.WriteAllText(path, jsonOne);
            string llegirJson = File.ReadAllText(path);
            List<Llibre> llibresJson = JsonConvert.DeserializeObject<List<Llibre>>(llegirJson);
            // Amb aquesta instrucció es transforma el json de la ruta d'accès especificada en el format de la llista indicada

            foreach (var llibre in llibresJson)
            {
                Console.WriteLine($"Títol: {llibre.Title}, Autor: {llibre.Author}, Any: {llibre.Year}");
            }
        }
    }
}