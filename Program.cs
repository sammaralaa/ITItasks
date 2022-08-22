using System;
using System.IO;
namespace Day5Tsak1
{
    class Program
    {
        static void Main(string[] args)
        {
            string readfile = File.ReadAllText(@"C:\Users\DELL\Documents\file1.txt");
            string[] words;
            string longestWord = " ";
            words = readfile.Split(" ");
            foreach(string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

            }
            Console.WriteLine(longestWord);
        }
    }
}
