using EX34;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

class Programa
{
    public static void Done()
    {
        List<Llibre> llibres = new List<Llibre>
        {
            new Llibre { Title = "The Seven Husbands Of Evelyn Hugo", Author = "Taylor Jenkins Reid", Year = 2018 },
            new Llibre { Title = "El Senyor dels Anells", Author = "J.R.R. Tolkien", Year = 1954 },
            new Llibre { Title = "Harry Potter i la Pedra Filosofal", Author = "J.K. Rowling", Year = 1997 }
        };

        // Crear un XmlSerializer per a la llista de llibres
        XmlSerializer serializer = new XmlSerializer(typeof(List<Llibre>));

        // Crear un fitxer per escriure-hi els llibres serialitzats
        using (StreamWriter writer = new StreamWriter(@"C:\Users\isard\Source\Repos\T4-EX\T4 - Exercises\Ex34\llibres.xml"))
        {
            serializer.Serialize(writer, llibres);
        }

        XDocument xmlDoc = XDocument.Load(@"C:\Users\isard\Source\Repos\T4-EX\T4 - Exercises\Ex34\llibres.xml");
        var book = from llibre in xmlDoc.Descendants("Llibre")
                      select new
                      {
                          Title = llibre.Element("Title").Value,
                          Author = llibre.Element("Author").Value,
                          Year = llibre.Element("Year").Value
                      };
        foreach (var llibre in book)
        {
            Console.WriteLine($"Títol: {llibre.Title}, Autor: {llibre.Author}, Any: {llibre.Year}");
        }
    }
}
