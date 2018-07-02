using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Tests
{
    [TestClass()]
    public class CustomerRepositoryTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void FindTestExistingCustomer()
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
    }
}