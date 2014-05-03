using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilectX
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=6;
            CountPrint c = new CustomCountPrint(7); 
            for (int i = 0; i < 10; i++) c.showNext();
          
            //int n=Console.Read();
            //CountPrint c = null;
            //if (n == '1')
            //{
            //    c = new CountPrint(20);
            //}
            //else
            //{
            //    c = new DoubleCountPrint();
            //}
            //for (int m = 1; m < 10; m++)
            //{
            //    c.showNext();
            //}
        }
    }
}
