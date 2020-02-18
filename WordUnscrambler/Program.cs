using System;
using System.Collections.Generic;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the scramble source - 'M' for manual or 'F' for file.");
            string scrambleSource = Console.ReadLine().ToUpper();
            
            switch (scrambleSource) {
                case "M":
                    ManualInput();
                    break;
                case "F":
                    FileInput();
                    break;
                default:
                    Console.WriteLine("Input not recognized.  Exiting the program.");
                    break;
            }
        }

        private static void ManualInput()
        {
            Console.WriteLine("Enter a word list in CSV format.");
            string manualInput = Console.ReadLine() ?? string.Empty;
            string[] words = manualInput.Split(",");
            List<WordPair> results = Processor.ProcessWords(words);

            PrintResults(results);

        }

        private static void FileInput()
        {

        }

        private static void PrintResults(List<WordPair> results)
        {
            foreach (WordPair result in results)
            {
                Console.WriteLine("The word {0} => {1}.", result.scrambledWord, result.unscrambledWord);
            }
        }
    }
}
