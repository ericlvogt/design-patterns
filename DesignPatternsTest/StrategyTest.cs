using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Strategy;

namespace DesignPatternsTest
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void TestStrategy()
        {
            IStrategy mean = new Average();
            IStrategy median = new Median();

            int x = 1;
            int y = 3;
            int z = 8;

            Assert.AreEqual(4, mean.GetMiddle(x, y, z));
            Assert.AreEqual(3, median.GetMiddle(x, y, z));
        }
    }
}