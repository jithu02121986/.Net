using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSequence.Model
{
    public class CheckSeq   
    {
        public bool checkInputSeq(string _text)
        {
            if (string.IsNullOrEmpty(_text) || _text.Length == 1)
            {
                return true;
            }
            for (int i = 1; i < _text.Length; i++)
            {
                if (_text[i] - _text[i - 1] != 1)
                {
                    //Console.WriteLine("check the sequence : text[i] :: " + _text[i] +" :: _text[i-1]" + _text[i - 1]);
                    return false;
                }
            }
            return true;
        }
    }
}
