using System;

namespace WordUnscrambler
{
        public struct WordPair
    {
        public string scrambledWord;
        public string unscrambledWord;

        public WordPair(string _scramabledWord, string _unscrambledWord)
        {
            scrambledWord = _scramabledWord;
            unscrambledWord = _unscrambledWord;
        }
    }
}