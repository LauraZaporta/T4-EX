using System.Collections;

namespace T4EX
{
    public class EX9
    {
        public static void Done()
        {
            const string AskName = "Type a name: ";
            const string InputFound = "This person is in the dictionary and their age is {0}";
            const string InputNotFound = "This name is not in the dictionary";

            Dictionary<string,int> registre = new Dictionary<string,int>();
            registre.Add("Marc", 21);
            registre.Add("Laura", 19);
            registre.Add("Pau", 22);

            foreach (KeyValuePair<string,int> reg in registre)
            {
                Console.WriteLine("Nom: {0}, Edat: {1}", reg.Key, reg.Value);
            }

            Console.Write(AskName);
            string? name = Console.ReadLine();

            if (registre.ContainsKey(name))
            {
                Console.WriteLine(InputFound, registre[name]);
;           } else { Console.WriteLine(InputNotFound); }

            registre.Remove("Laura");

            foreach (KeyValuePair<string, int> reg in registre)
            {
                Console.WriteLine("Nom: {0}, Edat: {1}", reg.Key, reg.Value);
            }

            //foreach (DictionaryEntry de in registre)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}",
            //        de.Key, de.Value);
            //}
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.system-collections-idictionary-getenumerator?view=net-9.0
        }
    }
}
