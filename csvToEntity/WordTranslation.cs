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
        public string Word { get; set; }

        public List<string> Translations { get; set; }

        public WordTranslation() { }
        public WordTranslation(string word, string translation)
        {
            Word = word;
            Translations = new List<string> { translation };
        }

        public WordTranslation(string word, List<string> translations)
        {
            Word = word;
            Translations = translations;
        }

        public void AddWordTranslation(string translation)
        {
            Translations.Add(translation);
        }

        public override string ToString()
        {
            return $"{Word} - {string.Join(", ", Translations)}";
        }

        //public override bool Equals(object obj)
        //{
        //    var item = obj as WordTranslation;

        //    if (item == null)
        //    {
        //        return false;
        //    }

        //    return Word.Equals(item.Word);
        //}
    }
}
