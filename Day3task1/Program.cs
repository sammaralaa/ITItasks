using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int max, num;
            Console.WriteLine("please enter a series of numbers separated by a comma.");
            input = Console.ReadLine();
           string[] numbers = input.Split(',');
            max = 0;
            foreach (string number in numbers) 
            {
                if (int.TryParse(number, out num))
                {
                    if (num > max)
                        max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
