using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo_App.Model
{
    public class ArrayListDemo
    {
        public void ArrayList_1()
        {
            System.Console.WriteLine("Array List Demo of Non-Generic :");
            ArrayList ar1 = new ArrayList();
            ar1.Add(1000);
            ar1.Add("Jitendra");
            ar1.Add(1000.52);

            int firstElement = (int)ar1[0];
            string secondElement = (string)ar1[1];
            double thirdElement = (double)ar1[2];

            System.Console.WriteLine($"First Element : {firstElement},Second Element : {secondElement },Third Element : {thirdElement}");
            //For each Loop 
            ar1[0] = "Medha";
            ar1[1] = 1003;
            foreach (var i in ar1)
            {
                System.Console.WriteLine($"For Each VAlues :{i}");
            }

           for (int i = 0;i<ar1.Count;i++)
           {
                System.Console.WriteLine($"For Loop  Values : {ar1[i]}");
            }
            Console.ReadKey();
        }
    }
}
