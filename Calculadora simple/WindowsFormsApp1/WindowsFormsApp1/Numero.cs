using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Numero
    {
        public double number;

        public Numero()
        {
            this.number = 0;
        }

        public Numero(double num)
        {
            this.number = num;
        }

        public Numero(string sNum)
        {
            double returnValue = 0;
            double.TryParse(sNum, out returnValue);
            this.number = returnValue;
        }
    }
}
