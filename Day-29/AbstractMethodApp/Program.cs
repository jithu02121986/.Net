using System;
using AbstractMethodApp.Model;
namespace AbstractMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Triangle(50, 60);
            Console.WriteLine("Shape class variable refer to triangle class object");
            s.DisplayArea();

            Shape s1 = new Rectangle(10, 20);
            Console.WriteLine("Shape class variable refer to Rectangle class object");
            s1.DisplayArea();
    }
    }
}
