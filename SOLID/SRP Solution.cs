using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solution
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
                ErrorHandler errorHandler = new ErrorHandler();
                errorHandler.HandleError(ex.ToString());
            }
        }
    }

    public class ErrorHandler
    {
        public void HandleError(string err)
        {
            File.WriteAllText(@"c:\Error.txt", err);
        }
    }
}
