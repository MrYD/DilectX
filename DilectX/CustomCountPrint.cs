using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilectX
{
    class CustomCountPrint : CountPrint
    {
        int delta;
        protected override int getnext() 
        {
            count = count + delta;
            return count;
        }
         public CustomCountPrint(int delta):base(0)
        {
            this.delta = delta;
        }
    }
}
