using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodApp.Model
{
    class Triangle : Shape
    {
        //private double radius;
        private double length;
        private double height;

        public Triangle(double length,double height)
        {
            this.length = length;
            this.height = height;
        }
        public override double caliculateArea()
        {
            return 0.5*length*height;
        }
    }
}
