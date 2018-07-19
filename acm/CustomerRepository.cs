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


        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + ", " + c.FirstName);
            return query;
        }


        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
            {
                Name = c.LastName + ", " + c.FirstName,
                c.EmailAddress
            });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ":" + item.EmailAddress);
            }

            return query;
        }

        public dynamic GetNamesAndId(List<Customer> customerList)
        {
            var query = customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName)
                .Select(c => new
                {
                    Name = c.LastName + ", " + c.FirstName,
                    c.CustomerID
                });

            return query.ToList();
        }



        public dynamic GetNamesAndType(List<Customer> customerList,
                                        List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                                c => c.CustomerTypeId, //outerKeySelector
                                ct => ct.CustomerTypeId, //innerKeySelector
                                (c, ct) => new
                                {
                                    Name = c.LastName + ", " + c.FirstName,
                                    CustomerTypeName = ct.TypeName
                                });
            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }
            return query.ToList();
        }

        public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customerList)
        {
            var query = customerList
                        .SelectMany(c => c.InvoiceList
                                    .Where(i => (i.IsPaid ?? false) == false),
                                    (c,i) => c).Distinct();
            return query;
        }

        public IEnumerable<KeyValuePair<string,decimal>> GetinvoiceTotalByCustomerType(List<Customer> customerList, List<CustomerType> customerTypeList)
        {
            var customerTypeQuery = customerList.Join(customerTypeList,
                                        c => c.CustomerTypeId,
                                        ct => ct.CustomerTypeId,
                                        (c, ct) => new
                                        {
                                            CustomerInstance = c,
                                            CustomerTypeName = ct.TypeName
                                        });

            var query = customerTypeQuery.GroupBy(c => c.CustomerTypeName,
                                                  c => c.CustomerInstance.InvoiceList.Sum(inv => inv.TotalAmount),
                                                  (groupKey, invTotal) => new KeyValuePair<string, decimal>(groupKey, invTotal.Sum())
                                                  );

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            return query;
        }


        public List<Customer> Retrive()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();

            List<Customer> custList = new List<Customer>()
            {
                new Customer()
                {
                    CustomerID = 1,
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "fb@hob.me",
                    CustomerTypeId = 1,
                    InvoiceList=invoiceRepository.Retrive(1),
                },
                new Customer()
                {
                    CustomerID = 2,
                    FirstName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId = null,
                    InvoiceList = invoiceRepository.Retrive(2),
        },
                new Customer()
                {
                    CustomerID = 3,
                    FirstName = "Samwise",
                    LastName = "Gamgee",
                    EmailAddress = "sg@hob.me",
                    CustomerTypeId = 4,
                    InvoiceList=invoiceRepository.Retrive(3),
                },
                new Customer()
                {
                    CustomerID = 4,
                    FirstName = "Rosie",
                    LastName = "Cotton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId = 2,
                    InvoiceList=invoiceRepository.Retrive(4),
                }
            };
            return custList;
        }

        public IEnumerable<Customer> RetriveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }

        public IEnumerable<Customer> SortByName(IEnumerable<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.LastName)
                .ThenByDescending(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse_Twin(List<Customer> customerList)
        {
            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.CustomerTypeId);
        }

        public IEnumerable<Customer> SortByTypeNullAtTheEnd(List<Customer> customerList)
        {   
            //HasValue would give false on null, falses goes first in ordering, so we put them at the end by using Descending
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue) 
                .ThenBy(c => c.CustomerTypeId);
        }
    }
}
