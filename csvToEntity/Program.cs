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
            {
                while(csv.Read())
                {   
                    if (csv[2] in wordsList.Contains())
                    wordsList.Add(new WordTranslation(csv[2].ToString(), csv[3].ToString()));
                    Console.WriteLine($"{csv[0]}, {csv[1]}, {csv[2]}, {csv[3]}");
                }
                //context.SaveChanges();
            }
        }
    }
}
