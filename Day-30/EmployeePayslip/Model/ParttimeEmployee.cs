using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EmployeePayslip.Model
{
    public class ParttimeEmployee : PayrollTeam

    {
        private string _name;
        //private string _email;
        //private double _gross_salary;
        private double _tax;
        private double net_salary;
        public double professional_tax = 200.00;
        public int _hourlyfee = 1500;
        private int _workinghours;


        public ParttimeEmployee(string _name, int _workinghours, double tax)
        {
            this._name = _name;
            this._workinghours = _workinghours;
            this._tax = tax;
        }

        public override double CaliculateSalary()
        {


            return net_salary = ((_hourlyfee * _workinghours) * 5) - professional_tax - _tax;

            Console.WriteLine("The employee salary breakup details are, Name: " + _name + "Working Hours :: " + _workinghours + "tax ::" + _tax);
            Console.WriteLine("\n");
            Console.WriteLine("Take home Salary ::" + net_salary);


        }
        
    }
    

}
