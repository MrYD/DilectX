using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilectX
{
    class CountPrint
    {
        protected int count = 0; 　//継承クラスにアクセス許可
        public void showNext()
        {
            Console.WriteLine(getnext());
        }

        public CountPrint(int initialCount) //型名なしのメソッド（コンストラクタ)
        {
            count = initialCount;   //new クラス名();
        }
        
        protected virtual int getnext()
        {
            return count++;
        }
    }
}
