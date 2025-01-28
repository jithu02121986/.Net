using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Model
{
    public class FulltimeEmployee : PayrollTeam
    {
        private string _name;
        //private string _email;
        private double _gross_salary;
        private double _tax;
        private double net_salary;
        public double professional_tax = 200.00;

        public FulltimeEmployee(string _name, double _gross_salary, double tax) {
            this._name = _name;
            this._gross_salary = _gross_salary;
            this._tax = tax;
        }

        public override double CaliculateSalary()
        {


            return net_salary = _gross_salary - _tax - professional_tax;

            
        }
    }
  }
    

