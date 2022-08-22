using System;

namespace Day1Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            System.Console.WriteLine("please enter two numbers");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int.TryParse(input1, out num1);
            int.TryParse(input2, out num2);
            if (num1 > num2)
            {
                System.Console.WriteLine(num1);
            }
            else
            {
                System.Console.WriteLine(num2);
            }
        }
    }
}
