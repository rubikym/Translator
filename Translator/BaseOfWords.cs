using System.Collections.Generic;

namespace Translator
{
    public class BaseOfWords
    {
        public List<Word> arrayWords { get; set; }

        private static BaseOfWords instance;

        private BaseOfWords()
        {
            arrayWords = new List<Word>();
        }

        public static BaseOfWords GetInstance()
        {
            if (instance == null)
                instance = new BaseOfWords();
            return instance;
        }

    }
}
