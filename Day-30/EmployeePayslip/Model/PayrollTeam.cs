using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Model
{
    public abstract class PayrollTeam
    {
        

       public abstract double CaliculateSalary();

        public void DisplayPaySlip()
        {
            Console.WriteLine($"Salary breakup details are :: {CaliculateSalary()}");
            
        }
    }
}
    
