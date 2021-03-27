using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Problem
{
    class Customer
    {
        private int _custType;

        public int CustType
        {
            get { return _custType; }
            set { _custType = value; }
        }

        public double CalculateDiscount()
        {
            if (_custType == 1)
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }
    }
}
