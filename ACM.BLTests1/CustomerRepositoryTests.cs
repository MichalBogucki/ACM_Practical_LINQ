using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.BLTest
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

        [TestMethod()]
        public void GetNamesTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var query = repository.GetNames(customerList);

            // Analyze
            foreach (var item in query)
            {
                TestContext.WriteLine(item);
            }

            // Assert
            Assert.IsNotNull(query);
        }

        [TestMethod()]
        public void GetNamesAndEmailTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var query = repository.GetNamesAndEmail(customerList);

            // NOT REALLY A TEST
        }

        [TestMethod()]
        public void GetNamesAndTypeTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            CustomerTypeRepository typeRepository = new CustomerTypeRepository();
            var customerTypeList = typeRepository.Retrive();

            // Act
            var query = repository.GetNamesAndType(customerList, customerTypeList);

            // NOT REALLY A TEST
        }

        [TestMethod]
        public void GetOverdueCustomersTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var query = repository.GetOverdueCustomers(customerList);

            // Assert
            foreach (var item in query)
            {
                    TestContext.WriteLine($"{item.LastName}: {item.FirstName}");
            }

            // Assert
            Assert.IsNotNull(query);
        }

        [TestMethod()]
        public void GetinvoiceTotalByCustomerTypeTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            CustomerTypeRepository typeRepository = new CustomerTypeRepository();
            var customerTypeList = typeRepository.Retrive();


            // Act
            var result = repository.GetinvoiceTotalByCustomerType(customerList,customerTypeList);

            //NOT REALLY A TEST
        }

        [TestMethod()]
        public void SortByNameTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.SortByName(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerID);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod()]
        public void SortByNameInReverseTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.SortByNameInReverse(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerID);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
        }
        [TestMethod()]
        public void SortByNameInReverseTest_Twin()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.SortByNameInReverse_Twin(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerID);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
        }

        [TestMethod()]
        public void SortByTypeTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.SortByType(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.First().CustomerTypeId);
        }

        [TestMethod()]
        public void SortByTypeNullAtTheEndTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrive();

            // Act
            var result = repository.SortByTypeNullAtTheEnd(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
        }
    }
}