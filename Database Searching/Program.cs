using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program        //this program is just practice using different query syntax and then some methods you can use to print the results
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("D:\\GitHub\\Codecademy-Projects\\Database Searching\\languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();                               //importing done by codecademy, i just copied full file path for the .tsv file

            int numOfLangs = languages.Count();
            Console.WriteLine(numOfLangs); 

             var langsFrom1995To2005 = languages
                .Where(l => l.Year >= 1995 && l.Year <= 2005)
                .Select(l => $"{l.Name} was invented in {l.Year}");

            var languageDesc = languages.Select(l => $"{l.Name} was written in {l.Year} by {l.ChiefDeveloper}");

            var csharp = languages
                .Where(l => l.Name.Contains("C#"))
                .Select(l => l); 

            var microsoftLangs = from l in languages
                                  where l.ChiefDeveloper.Contains("Microsoft")
                                  select l;

            var findLispDescendants = languages.Where(l => l.Predecessors.Contains("Lisp"));
            var containsLisp = findLispDescendants.Select(l => l); 

            var scripts = languages.Where(l => l.Name.Contains("Script")).Select(l => l.Name);

            var orderByName = languages.OrderBy(l => l.Name);

            var orderByOldest = languages.Min(l => l.Year);

            //PrettyPrintAll(languages);
            //PrintAll(langsFrom1995To2005);

        }

        public static void PrettyPrintAll(IEnumerable<Language> listOfLangs)
        {
            foreach (Language lang in listOfLangs)
            {
                Console.WriteLine(lang.Prettify());
            }
        }

        public static void PrintAll(IEnumerable<Object> queryResult)
        {
            foreach (Object obj in queryResult)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
