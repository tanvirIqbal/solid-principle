using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Problem
{
    public class CustomarMain
    {
        public void Add()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            customers.Add(new EnqueriCustomer());

            foreach (Customer customer in customers)
            {
                customer.Add();
            }
        }
    }
    public class Customer
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

    public class EnqueriCustomer : Customer
    {
        public override void Add()
        {
            throw new NotImplementedException("Not for save");
        }
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 2;
        }
    }
}
