using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo_App.Model
{
    public class DictonaryDemo
    {
        public void _DictonaryDemo_1()
        {
            //Dictionary<int,string> dict = new Dictionary<int,string>();
            SortedDictionary<int,string> dict = new SortedDictionary<int,string>();
            dict.Add(1, "Jitendra");
            dict.Add(3, "Medha");
            dict.Add(5, "Akkilesh");
            dict.Add(2, "Ganesh");

            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine($"key : {kvp.Key} Value : {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
