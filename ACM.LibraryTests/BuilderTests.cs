using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library.Tests
{
    [TestClass()]
    public class BuilderTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void BuildIntegerSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.BuildIntegerSequence();

            // Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BuildStringSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.BuildStringSequence();

            // Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BuildRandomStringSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.BuildRandomStringSequence();

            // Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }
            
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BuildRanCompareSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.CompareSequences();

            // Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
