using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu_WinFormsApp1
{
    internal class Claculator
    {
        private int _operand1;
        private int _operand2;
        private int _result;

        public int Operand1
        {
            //get { return _operand1; }
            set
            {
                if (_operand1 > _operand2)
                    throw new ApplicationException("operand2 must greater than op1");
                _operand1 = value;
            }
        }
        public int Operand2
        {
            //get { return _operand2; }
            set { _operand2 = value; }
        }
        public int Result
        {
            get { return _result; }
        }
        public void Add()
        {
           _result = _operand1  + _operand2;
        }
        public void sub()
        {
            _result = _operand1 - _operand2;
        }
        public void Mul()
        {
            _result = _operand1 * _operand1;
        }

        public void Div()
        {
            if(_operand2 == 0)
            {
                throw new ApplicationException("Denominator must greater than 0");
            }
            _result = _operand2 / _operand1;
        }
    }
}
