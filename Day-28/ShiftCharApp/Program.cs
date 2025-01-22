using System;
using ShiftCharApp.Model;

namespace ShiftCharApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
           Shiftchar sh = new Shiftchar();
            string name = "abcd";
            string temp_1 = sh.reversChar(name);

            Console.WriteLine("Input String : "+name);
            Console.WriteLine("Out Put String : "+temp_1);
        }
    }
}
