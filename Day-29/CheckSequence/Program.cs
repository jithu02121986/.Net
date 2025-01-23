using System;
using CheckSequence.Model;

namespace CheckSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckSeq cs = new CheckSeq();
            Console.WriteLine("Given string is in seq order : " + cs.checkInputSeq("abcdefgh"));
            Console.WriteLine("Given string is in seq order : " + cs.checkInputSeq("dagder"));
            Console.WriteLine("Given string is in seq order : " + cs.checkInputSeq("aaa"));
            Console.WriteLine("Given string is in seq order : " + cs.checkInputSeq("a"));
        }
    }
}
