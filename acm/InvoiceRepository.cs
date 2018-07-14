using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class InvoiceRepository
    {
        public List<Invoice> Retrive(int customerId)
        {
            List<Invoice> invoiceList = new List<Invoice>
            {
                new Invoice()
                {
                    InvoiceId = 1,
                    Customerid = 1,
                    InvoiceDate = new DateTime(2013, 6, 20),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null

                },
                new Invoice()
                {
                    InvoiceId = 2,
                    Customerid = 1,
                    InvoiceDate = new DateTime(2013, 7, 20),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null}
                ,
                new Invoice()
                {
                    InvoiceId = 3,
                    Customerid = 2,
                    InvoiceDate = new DateTime(2013, 7, 25),
                    DueDate = new DateTime(2013, 8 ,29),
                    IsPaid = null

                },
                new Invoice()
                {
                    InvoiceId = 4,
                    Customerid = 3,
                    InvoiceDate = new DateTime(2013, 7, 1),
                    DueDate = new DateTime(2013, 9 ,1),
                    IsPaid = true
                }
            };
            List<Invoice> filteredList = invoiceList.Where(i => i.Customerid == customerId).ToList();

            return filteredList;
        }
    }
}
