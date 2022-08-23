using System;

namespace Day4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack2 ss = new Stack2();
           // ss.Clear();
            ss.Push(1);
            ss.Push(2);
            ss.Push(3);
            Console.WriteLine(ss.Pop());
            Console.WriteLine(ss.Pop());
            Console.WriteLine(ss.Pop());
        }
    }
}
