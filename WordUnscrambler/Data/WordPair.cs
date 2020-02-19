using System;

namespace WordUnscrambler
{
        struct WordPair
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