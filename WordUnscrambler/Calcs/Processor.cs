using System;
using System.IO;
using System.Collections.Generic;
using WordUnscrambler.Data;

namespace WordUnscrambler
{
    public class Processor
    {
        public static string[] GetReferenceWords()
        {
            string[] ret = File.ReadAllLines(Constants.referenceUnscrambledFile);
            return ret;
        }
        public static List<WordPair> ProcessWords(string[] words)
        {
            string[] referenceWords = GetReferenceWords();
            List<WordPair> wordPairList = new List<WordPair>();
            foreach(string word in words)
            {
                string _word = WordSort(word);
                foreach(string refWord in referenceWords)
                {
                    string _refWord = WordSort(refWord);
                    if (_word.Equals(_refWord)) {
                        wordPairList.Add(new WordPair(word, refWord));
                    }
                }
            }
            return wordPairList;
        }

        private static string WordSort(string word)
        {
            char[] _wordArr = word.Trim().ToUpper().ToCharArray();
            Array.Sort(_wordArr);
            word = new string(_wordArr);
            return word;
        }

    }
}
