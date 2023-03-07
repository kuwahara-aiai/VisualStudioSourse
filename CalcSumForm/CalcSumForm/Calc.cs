using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSumForm
{
    public class Calc
    {
        public int num1 = 0;    //1つ目の数
        public int num2 = 0;    //2つ目の数
        //足し算の結果を得るメソッド
        public int Add()
            {
            return this.num1 + this.num2;
        }
    }
}
