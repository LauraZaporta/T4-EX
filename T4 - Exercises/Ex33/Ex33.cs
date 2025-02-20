using System;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;

public class Persona //Es crea una classe amb els camps que es volen llegir
{
    public string Nom { get; set; }
    public int Edat { get; set; }
    public string Ciutat { get; set; }
}
public class Program
{
    public static void Done()
    {
        using (var reader = new StreamReader(@"C:\Users\isard\Source\Repos\T4-EX\T4 - Exercises\Ex33\alumnes.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var registres = csv.GetRecords<Persona>();
            foreach (var persona in registres)
            {
                Console.WriteLine($"Nom: {persona.Nom}, Edat: {persona.Edat}, Ciutat: {persona.Ciutat}");
            }
        }
    }
}