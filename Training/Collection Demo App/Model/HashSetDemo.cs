using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo_App.Model
{
    public class HashSetDemo
    {
        public void _HashsetDemo()
        { 
            HashSet<int> dic = new HashSet<int>();
            dic.Add(1);
            dic.Add(2);
            dic.Add(5);
            dic.Add(3);
            dic.Add(3);

            foreach (int item in dic)
            {
                Console.WriteLine($"Hash set Data : {item}");
            }
        }
    }
}
