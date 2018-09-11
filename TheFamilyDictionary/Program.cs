using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            {
                { "name", "Hiwote"},
                { "age", "39"},
            });
            myFamily.Add("brother", new Dictionary<string, string>()
            {
                { "name", "Estifo"},
                { "age", "37"},
            });
            myFamily.Add("father", new Dictionary<string, string>()
            {
                { "name", "Simmie"},
                { "age", "68"},
            });

            foreach (var family in myFamily)
            {
                Console.WriteLine($"{family.Value["name"]} is my {family.Key} and is {family.Value["age"]} years old.");
            }
            Console.ReadLine();
              
        }

    }
}
