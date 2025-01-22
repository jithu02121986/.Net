using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisamconcept.Model
{
class Employee_1
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _salary;

        public Employee_1(int id,string name,double salary) { 
            _id = id;
            _name = name;
            _salary = salary;
                    
        }
        public int getId() 
        {
            return _id; 
        }
        public string getName()
        {
            return _name;
        }
        public double getSalary()
        {

            return _salary;
        }
        public override string ToString()

        {
            Console.WriteLine("Inside To string Method");
            return $"ID--> {_id},Name-->{_name},Salary-->{_salary}";
            
        }

    }
}
