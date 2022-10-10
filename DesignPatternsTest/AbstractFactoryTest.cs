using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.AbstractFactory;

namespace DesignPatternsTest
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void TestCreateProduct()
        {
            IProductFactory productFactory = new ProductFactory();
            IProduct product = productFactory.CreateProduct();
            Assert.IsInstanceOfType(product, typeof(Product));
        }
    }
}
