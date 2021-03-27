using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Problem
{
    public class CustomarMain
    {
        public void Demo ()
        {
            ICustomer customer = new Customer();
            customer.Add();
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
    public class Customer : ICustomer
    {
        public virtual void Add()
        {
            // Add customer to the database
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
