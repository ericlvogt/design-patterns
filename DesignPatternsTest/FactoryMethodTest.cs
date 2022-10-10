using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.FactoryMethod;

namespace DesignPatternsTest
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void TestCreateProduct()
        {
            ICreator creator = new Creator();
            IProduct product = creator.CreateProduct();
            Assert.IsInstanceOfType(product, typeof(Product));
        }
    }
}
