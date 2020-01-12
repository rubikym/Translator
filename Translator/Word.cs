using System;

namespace Translator
{
    public class Word
    {
        public int id { get; set; }
        public Languages language { get; set; }

        public string word { get; set; }

        public string translation { get; set; }
    }
}
