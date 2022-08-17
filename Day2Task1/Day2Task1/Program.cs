using System;

namespace Day2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1="", name2="";
            string input;
            int counter = 0;
            while (true)
            {
                System.Console.WriteLine("please enter a name");
                input = System.Console.ReadLine();
                if (input=="")
                    break;
                else
                {
                    counter++;
                    if (counter == 1)
                        name1 = input;
                    else if (counter == 2)
                        name2 = input;
                }                
            }
            switch (counter)
            {
                case 0:
                    break;
                case 1:
                    System.Console.WriteLine($"{name1} likes your post");
                    break;
                case 2:
                    System.Console.WriteLine($"{name1} and {name2} likes your post");
                    break;
                default:
                    System.Console.WriteLine($"{name1} and {name2} and {counter} others like your post");
                    break;
            }
        }
    }
}
