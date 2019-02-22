using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "";

            while (words != "x")
            {
                Console.WriteLine("Enter some words");
                words = Console.ReadLine();
                Console.WriteLine("Words entered: " + words);
                Console.WriteLine("Number of Letters: " + words.Length);

                LinqReverse(words);
                StringBuilderReverse(words);
            }

            string path = @"C:\Users\wallingtonc\Documents\Pluralsight Training\Week 2 - Github.txt";

            FileStreamRead(path);

            StreamReaderCount(path);

        }

        private static void StreamReaderCount(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                int linecount = 0;
                while (streamReader.ReadLine() != null)
                {
                    linecount++;
                }
                Console.WriteLine("Number of lines: " + linecount);

            }
        }

        // Streams implement IDisposable so wrap them in the using pattern
        private static void FileStreamRead(string path)
        {
            using (var file = new FileStream(path, FileMode.Open))
            {
                Console.WriteLine("File name: " + file.Name);
                Console.WriteLine("File size: " + file.Length);
            }
        }

        // Showing you there are alternatives to reading the whole file
        private static void FileInfo(string path)
        {
            var fileInfo = new FileInfo(path);
            var length = fileInfo.Length;
        }

        // Showing you how I would have tackled this reverse words challenge
        // Possibly more readable than the alternatives - would need to test performance though
        private static string WordsReverse(string words)
        {
            var wordArray = Regex.Split(words, "\b");
            Array.Reverse(wordArray);
            return String.Join(" ", wordArray);
        }

        private static void LinqReverse(string words)
        {
            string wordsbackwards = string.Join(" ", words.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine("Words in reverse order: {0}", wordsbackwards);
        }

        private static void StringBuilderReverse(string words)
        {
            StringBuilder sb = new StringBuilder();
            string[] split = words.Split(' ');
            for (int i = split.Length - 1; i > -1; i--)
            {
                sb.Append(split[i]);
                sb.Append(" ");
            }
            Console.WriteLine("String Builder Reverse: {0}", sb);
        }
    }
    //test

    //class Words
    //{
    //    public string word { get; set; }
    //}
}
