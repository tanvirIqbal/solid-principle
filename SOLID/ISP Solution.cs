using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solution
{
    public class CustomarMain
    {
        public void Demo ()
        {
            ICustomer oldCustomerUser = new Customer();
            oldCustomerUser.Add();

            IRead newCustomerUser = new Customer();
            newCustomerUser.Add();
            newCustomerUser.Read();
        }
        

    }
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
        //void Read();
    }
    public interface IRead : ICustomer
    {
        void Read();
    }
    public class Customer : ICustomer, IRead
    {
        public virtual void Add()
        {
            // Add customer to the database
        }

        public virtual void Read()
        {
            // Read customer from the database
        }

        public virtual double CalculateDiscount()
        {

            return 0;

        }

    }

    public class GoldCustomer : Customer
    {
        public override void Add()
        {
            // Add Gold customer to the database
        }
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
    }

    public class SilverCustomer : Customer
    {
        public override void Add()
        {
            // Add Silver customer to the database
        }
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
    }

    public class EnqueriCustomer : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
        }
    }
}
