using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsyncApp.Services
{
    internal class PrintServices
    {
        public void Print() 
        {
            Debug.WriteLine($"Time IS  :: {DateTime.Now.ToString("hh:mm:ss")}");
        }
        public void prinviaThread()
        {
            Thread t = new Thread(Print);
            t.Start();
        }
    }
}
