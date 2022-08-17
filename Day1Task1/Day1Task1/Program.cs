using System;

namespace Day1Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("please enter a number");
            string input1 = System.Console.ReadLine();
            int.TryParse(input1, out num);

            if (num >= 1 && num <= 10)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }

        }
    }
}
