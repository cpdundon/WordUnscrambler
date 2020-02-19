using System;
using System.Collections.Generic;
using System.IO;
using WordUnscrambler.Data;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            string userEngaged = string.Empty;
            do{
                Console.WriteLine("Please enter the scramble source - 'M' for manual or 'F' for file.");
                string scrambleSource = Console.ReadLine().ToUpper();
                switch (scrambleSource)
                {
                    case "M":
                        ManualInput();
                        break;
                    case "F":
                        FileInput();
                        break;
                    default:
                        throw new Exception("Manual or File input data not recognized.  Exiting the program.");
                }
                Console.WriteLine("Enter '{0}' to continue.  Other entries will terminate the program.", Constants.approvalIndicator);
                userEngaged = Console.ReadLine().Trim().ToUpper() ?? string.Empty;
            } while (userEngaged.Equals(Constants.approvalIndicator));
        } catch (Exception ex)
        {
            Console.WriteLine("We have experienced an error.  Program is exiting.");
            Console.WriteLine(ex.Message);
        } finally
        {
            Console.WriteLine("Thank You.");
        }}

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
            Console.WriteLine("Enter the path to your file.");
            string filePath = Console.ReadLine() ?? string.Empty;
            string[] words = File.ReadAllLines(filePath);
            List<WordPair> results = Processor.ProcessWords(words);

            PrintResults(results);

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
