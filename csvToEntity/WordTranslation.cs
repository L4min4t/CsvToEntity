using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csvToEntity
{
    internal class WordTranslation
    {
        public WordTranslation() { }
        public WordTranslation(string word, string translations)
        {
            Word = word;
            Translations.Append(translations);
        }
        public WordTranslation(string word, List<string> translations)
        {
            Word = word;
            Translations = translations;
        }

        public string Word { get; set; }

        public List<string> Translations { get; set; }

        public void AddWordTranslation(string translation)
        {
            Translations.Add(translation);
        }

        public override string ToString()
        {
            return $"{Word} - {string.Join(" ", Translations)}";
        }
    }
}
