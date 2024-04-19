using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.計算機.Operators
{
    internal class Multi : Oper
    {
        public override int Calc(int number1, int number2)
        {
           return number1 * number2;
        }
    }
}
