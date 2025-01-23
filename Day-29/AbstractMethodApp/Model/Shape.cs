using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodApp.Model
{
    public abstract class Shape
    {
        public abstract double caliculateArea();//Abstract Method

        public void DisplayArea()
        {
            Console.WriteLine($"Area of the shape is : : {caliculateArea()}");
        }
       
    }
}
