using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.計算機.Operators
{
    internal class OperFactory
    {
        public static Oper creat(String type)
        {
            Oper oper = null;
            switch (type)
            {
                case ("+"):
                    oper = new Add();
                    break;
                case ("-"):
                    oper = new Minus();
                    break;
                case ("*"):
                    oper=new Multi();
                    break;
                case ("/"):
                    oper=new Division();
                    break;
            }
            return oper;
        }
    }
}
