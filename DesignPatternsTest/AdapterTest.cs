using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Adapter;

namespace DesignPatternsTest
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestMultipleInheritance()
        {
            string text = "Testing";
            ITarget adapterTarget = new AdapterMultipleInheritance(text);
            IAdaptee adapterAdaptee = (IAdaptee)adapterTarget;

            Assert.AreEqual(text, adapterTarget.GetText());
            Assert.AreEqual(text, adapterAdaptee.GetMessage());
        }

        [TestMethod]
        public void TestObjectComposition()
        {
            string text = "Testing";
            IAdaptee adaptee = new Adaptee(text);
            ITarget adapterTarget = new AdapterObjectComposition(adaptee);

            Assert.AreEqual(text, adaptee.GetMessage());
            Assert.AreEqual(text, adapterTarget.GetText());
        }
    }
}
