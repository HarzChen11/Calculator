 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.計算機.Operators;

namespace WindowsFormsApp1.計算機
{
    internal class Calc
    {
        private int _number1;
        private int _number2;
        private string _oper;

        //public Calc(int number1, int number2, string oper)
        //{
        //    this.number1 = number1;
        //    this.number2 = number2;
        //    this.oper = oper;
        //}


        public String Number1
        {
            get
            {
                return this._number1.ToString();
            }
            set
            {
                this._number1 = int.Parse(value);
            }
        }

        public String Number2
        {
            get
            {
                return this._number2.ToString();
            }
            set
            {
                this._number2 = int.Parse(value);
            }
        }

        public string Oper
        {
            get
            {
                return this._oper;
            }
            set
            {
                this._oper = value;
            }
        }



       

        //public int Result()
        //{
        //    int total = 0;
        //    switch (Oper)
        //    {
        //        case ("+"):
        //            total = _number1 + _number2;
        //            break;
        //        case ("-"):
        //            total = _number1 - _number2;
        //            break;
        //        case ("*"):
        //            total = _number1 * _number2;
        //            break;
        //        case ("/"):
        //            total = _number1 / _number2;
        //            break;
        //    }
        //    return total;
        //}

        public String ResultTxt
        {
            get {
                // 高層次的模組不應該依賴低層次的模組，兩者應該依賴於抽象
                Oper oper = OperFactory.creat(this._oper);
                int total = oper.Calc(this._number1, this._number2);
                return total.ToString();
            }
        }
    }
}




