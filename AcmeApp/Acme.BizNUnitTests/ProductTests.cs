using NUnit.Framework;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.NUnitTests
{
    [TestFixture()]
    public class ProductTests
    {
        // This class demonstrates the three ways that objects can be initialized
        // Set properties is good when populating an object with database values (type conversions, null value exceptions)
        // Parameterized constructors are good for establishing the basic set of properties of an object
        // Object initializers are good when readability is important, or when initializing a subset or a superset of properties

        [Test()]
        public void SayHelloTest()
        {
            // Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            currentProduct.ProductVendor.CompanyName = "ABC Corp";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SayHelloParameterizedConstructor()
        {
            // Arrange
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SayHelloTestUsingObjectInitialization()
        {
            // Arrange
            var currentProduct = new Product
            {
                ProductName = "Saw",
                ProductId = 1,
                Description = "15-inch steel blade hand saw"
            };

        var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Product_Null()
        {
            // Arrange using the Null-Conditional Operator
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;

            string expected = null;

        // Act
        var actual = companyName;

        // Assert
        Assert.AreEqual(expected, actual);
        }
    }
}

