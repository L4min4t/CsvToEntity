using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace csvToEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<WordTranslation> wordsList = new List<WordTranslation>();

            Console.OutputEncoding = Encoding.UTF8;

            var csv = new CsvReader(new StreamReader("../../1.csv", Encoding.UTF8), CultureInfo.InvariantCulture);
            
            while(csv.Read())
            {
                if (wordsList.Any(x => x.Word == csv[2]))
                {
                    //Console.WriteLine(csv[2]);  
                    wordsList.First(x => x.Word == csv[2]).Translations.Add(csv[3].ToString());
                }
                else
                {
                    wordsList.Add(new WordTranslation(csv[2].ToString(), csv[3].ToString()));
                }
            }

            foreach (var word in wordsList.OrderBy(x => x.Word))
            {
                Console.WriteLine(word.ToString()); 
            }
        }
    }
}
