using System;
using EmployeePayslip.Model;

namespace EmployeePayslip
{
    internal class Program
    {
        static void Main(string[] args)
        {
          PayrollTeam team = new FulltimeEmployee("Sai Kumar",90000.00,28000.00);
           
            team.CaliculateSalary();
            team.DisplayPaySlip();

            //calling parttime employee class

            PayrollTeam team1 = new ParttimeEmployee("Ravi Varma", 7, 1000.00);

            team1.CaliculateSalary();
            team1.DisplayPaySlip();
        }
    }
}
