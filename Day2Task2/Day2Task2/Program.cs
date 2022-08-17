using System;

namespace Day2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num, factorial = 1 ;
            bool isNum;
            Console.WriteLine("please enter a number");
            input = Console.ReadLine();
            isNum = int.TryParse(input, out num);
            if (isNum)
            {
                for(int i = 2; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"{num}! = {factorial}");
            }
        }
    }
}
