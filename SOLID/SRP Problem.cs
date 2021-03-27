using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Problem
{
    class Customer
    {
        public void Add ()
        {
            try
            {
                // Add customer to the database
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
}
