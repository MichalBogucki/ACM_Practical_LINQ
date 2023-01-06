using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class InvoiceRepository
    {

        public decimal CalculateTotalAmountInvoiced(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(x => x.TotalAmount);
        }

        public decimal CalculateTotalUnitSold(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(x => x.NumberOfUnits);
        }

        public dynamic GetInvoiceTotalByIsPaid(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(inv => inv.IsPaid ?? false,
                inv => inv.TotalAmount,
                (groupKey, invTotal) => new
                {
                    Key = groupKey,
                    InvoiceAmount = invTotal.Sum()
                });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.InvoiceAmount}");
            }

            return query;
        }

        public dynamic GetInvoiceTotalByIsPaidAndMonth(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(inv => new
                {
                    IsPaid = inv.IsPaid ?? false,
                    InvoiceMonth = inv.InvoiceDate.ToString("MMMM")
                },
                inv => inv.TotalAmount,
                (groupKey, invTotal) => new
                {
                    Key = groupKey,
                    InvoiceAmount = invTotal.Sum()
                });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key.IsPaid} / {item.Key.InvoiceMonth}: {item.InvoiceAmount}");
            }

            return query;
        }


        /// <summary>
        /// Retrives list of invoices
        /// </summary>
        /// <returns></returns>
        public List<Invoice> Retrive()
        {
            List<Invoice> invoiceList = new List<Invoice>
            {
                new Invoice()
                {
                    InvoiceId = 1,
                    Customerid = 1,
                    InvoiceDate = new DateTime(2013, 6, 20),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null,
                    Amount = 199.99M,
                    NumberOfUnits = 20,
                    DiscountPercent = 0M
                },
                new Invoice()
                {
                    InvoiceId = 2,
                    Customerid = 1,
                    InvoiceDate = new DateTime(2013, 7, 20),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null,
                    Amount  = 98.50M,
                    NumberOfUnits = 10,
                    DiscountPercent = 10M
                },
                new Invoice()
                {
                    InvoiceId = 3,
                    Customerid = 2,
                    InvoiceDate = new DateTime(2013, 7, 25),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null,
                    Amount = 250M,
                    NumberOfUnits = 25,
                    DiscountPercent = 10M
                },
                new Invoice()
                {
                    InvoiceId = 4,
                    Customerid = 3,
                    InvoiceDate = new DateTime(2013, 7, 1),
                    DueDate = new DateTime(2013, 9 ,1),
                    IsPaid = true,
                    Amount = 20M,
                    NumberOfUnits = 2,
                    DiscountPercent = 15M
                },
                new Invoice()
                {
                    InvoiceId = 5,
                    Customerid = 1,
                    InvoiceDate = new DateTime(2013, 8, 20),
                    DueDate = new DateTime(2013, 9 ,29),
                    IsPaid = true,
                    Amount = 225M,
                    NumberOfUnits = 8,
                    DiscountPercent = 0M
                },
                new Invoice()
                {
                    InvoiceId = 6,
                    Customerid = 2,
                    InvoiceDate = new DateTime(2013, 8, 20),
                    DueDate = new DateTime(2013, 8, 20),
                    IsPaid = false,
                    Amount = 75M,
                    NumberOfUnits = 8,
                    DiscountPercent = 0M
                },
                new Invoice()
                {
                    InvoiceId = 7,
                    Customerid = 3,
                    InvoiceDate = new DateTime(2013, 8, 25),
                    DueDate = new DateTime(2013, 9 ,25),
                    IsPaid = null,
                    Amount = 500M,
                    NumberOfUnits = 42,
                    DiscountPercent = 10M
                },
                new Invoice()
                {
                    InvoiceId = 8,
                    Customerid = 4,
                    InvoiceDate = new DateTime(2013, 8, 1),
                    DueDate = new DateTime(2013, 9 ,1),
                    IsPaid = true,
                    Amount = 75M,
                    NumberOfUnits = 7,
                    DiscountPercent = 0M
                }
            };

            return invoiceList;
        }

        /// <summary>
        /// Retrives the list of invoices
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public List<Invoice> Retrive(int customerId)
        {
            var invoiceList = this.Retrive();

            List<Invoice> filteredList = invoiceList.Where(i => i.Customerid == customerId).ToList();
            return filteredList;
        }

    }
}
