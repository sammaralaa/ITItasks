using System;

namespace Day4task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p = new Post();
            p.up_vote();
            p.up_vote();
            p.up_vote();
            p.down_vote();
            p.down_vote();
            p.up_vote();
            p.up_vote();
            p.up_vote();
            p.up_vote();
            Console.WriteLine( p.printVotevalue());

        }
    }
}
