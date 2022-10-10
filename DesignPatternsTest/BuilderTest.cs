using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Builder;

namespace DesignPatternsTest
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void TestCreateProduct()
        {
            IProductBuilder builder = new ProductBuilder();
            IDirector director = new Director(builder);

            director.Construct();
            IProduct product = builder.GetProduct();

            Assert.IsInstanceOfType(product, typeof(Product));
            Assert.AreEqual(2, product.SubProductCount);
        }
    }
}
