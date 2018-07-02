using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;


            foundCustomer = customerList.FirstOrDefault(x => x.CustomerID.Equals(customerId));

            return foundCustomer;
        }

        public Customer FindSecond(List<Customer> customerList, int customerTypeId)
        {
            Customer foundCustomer = null;


            foundCustomer = customerList
                .Where(x => x.CustomerTypeId.Equals(customerTypeId))
                .Skip(1)
                .FirstOrDefault();

            return foundCustomer;
        }

        public List<Customer> Retrive()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer()
                {
                    CustomerID = 1,
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "fb@hob.me",
                    CustomerTypeId = 1
                },
                new Customer()
                {
                    CustomerID = 2,
                    FirstName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId = null
                },
                new Customer()
                {
                    CustomerID = 3,
                    FirstName = "Samwise",
                    LastName = "Gamgee",
                    EmailAddress = "sg@hob.me",
                    CustomerTypeId = 1
                },
                new Customer()
                {
                    CustomerID = 4,
                    FirstName = "Rosie",
                    LastName = "Cotton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId = 2
                }
            };
            return custList;
        }
    }
}
