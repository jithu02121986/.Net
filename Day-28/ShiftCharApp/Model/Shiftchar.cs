using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCharApp.Model
{
    public class Shiftchar
    {
        string _name;
        public string reversChar(string name) 
        {
            char[] tempArray = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
               // Console.WriteLine("length : "+i);
                tempArray[i] = (char)(name[i]+1);
                Console.WriteLine("temp array" + tempArray[i]);

            }

            return new string(tempArray);
        }
    }
}
