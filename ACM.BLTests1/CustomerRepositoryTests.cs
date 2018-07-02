using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Tests
{
    [TestClass()]
    public class CustomerRepositoryTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void FindTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.Find(customerList, 2);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerID);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod()]
        public void FindSecondTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.FindSecond(customerList, 1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.CustomerID);
            Assert.AreEqual("Samwise", result.FirstName);
            Assert.AreEqual("Gamgee", result.LastName );
        }


        [TestMethod()]
        public void FindTestNotFound()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.Find(customerList, 42);

            // Assert
            Assert.IsNull(result);
        }
    }
}