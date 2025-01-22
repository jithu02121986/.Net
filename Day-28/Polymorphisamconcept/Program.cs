using System;
using Polymorphisamconcept.Model;

namespace Polymorphisamconcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // caseStudy1();
             caseStudy2();

        }

        private static void caseStudy2()
        {
            var emp = new Employee_1(100, "Jitendra", 15000);
            var emp1 = new Employee_1(100, "Jitendra", 15000);
            Console.WriteLine(emp.Equals(emp1));
            Console.WriteLine(emp == emp1);

            Console.WriteLine(emp.GetType());
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.getId());
        }

        private static void caseStudy1()
        {
            var emp = new Employee_1(100, "Jitendra", 15000);
            Console.WriteLine(emp.GetType());
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.getId());
        }
    }
}
