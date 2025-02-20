using System;
using System.Xml.Serialization;

namespace EX35
{
    [Serializable]
    public class Llibre
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
    }
}
