using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Problem
{
    public class CustomarMain
    {
        public void Demo()
        {
            Customer customer = new Customer();
            customer.Add();
        }


    }
    class Customer
    {
        IErrorHandler errorHandler = new FileErrorHandler();
        public void Add ()
        {
            try
            {
                // Add customer to the database
            }
            catch (Exception ex)
            {
                errorHandler.HandleError(ex.ToString());
            }
        }
    }
    public interface IErrorHandler
    {
        void HandleError(string err);
    }
    public class FileErrorHandler : IErrorHandler
    {
        public void HandleError(string err)
        {
            
        }
    }

    public class XMLErrorHandler : IErrorHandler
    {
        public void HandleError(string err)
        {
            
        }
    }
}
