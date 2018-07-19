using ACM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class InvoiceRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void CalculateTotalAmountInvoicedTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrive();

            // Act
            var actual = repository.CalculateTotalAmountInvoiced(invoiceList);

            // Assert
            Assert.AreEqual(1355.640M, actual);
        }

        [TestMethod()]
        public void CalculateTotalUnitSoldTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrive();

            // Act
            var actual = repository.CalculateTotalUnitSold(invoiceList);

            // Assert
            Assert.AreEqual(122, actual);
        }

        [TestMethod()]
        public void GetInvoiceTotalByIsPaidTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrive();

            // Act
            var query = repository.GetInvoiceTotalByIsPaid(invoiceList);

            // Assert
        }

        [TestMethod()]
        public void GetinvoiceTotalByIsPaidAndMonthTest()
        {
            // Arrange
            InvoiceRepository repository = new InvoiceRepository();
            var invoiceList = repository.Retrive();

            // Act
            var query = repository.GetInvoiceTotalByIsPaidAndMonth(invoiceList);

            // Assert
        }
    }
}