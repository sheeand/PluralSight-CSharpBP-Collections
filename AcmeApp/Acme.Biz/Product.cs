using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class Product
    {
        private string productName;
        private string description;
        private int productId;
        private Vendor productVendor;

        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        public Product(int productId, string productName, string description) :this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
            Console.WriteLine("Product instance as a name: " + ProductName);
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        // Example of "Lazy Loading"
        public Vendor ProductVendor
        {
            get
            {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        public string SayHello()
        {
            var testProductName = "";
            var product = new Product(2, "Chair", "Red sofa");

            if (product != null && product.ProductName != null)
            {
                testProductName = product.ProductName.Trim();
            }
            
            // using null-conditional operator
            testProductName = product?.ProductName?.Trim();


            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }
    }
}
