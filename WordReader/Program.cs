using System;
using System.IO;
using System.Linq;
using System.Text;

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

        private static void FileStreamRead(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            Console.WriteLine("File name: " + file.Name);
            Console.WriteLine("File size: " + file.Length);
            file.Close();
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
