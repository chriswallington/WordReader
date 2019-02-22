using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "";

// had a look at if statements, but effectively runs once. While will execute until condition is met

            while (words != "x")
            {
                Console.WriteLine("Enter some words");
                words = Console.ReadLine();
                Console.WriteLine("Words entered: " + words);
                Console.WriteLine("Number of Letters: " + words.Length);

                LinqReverse(words);
                StringBuilderReverse(words);
            }


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
