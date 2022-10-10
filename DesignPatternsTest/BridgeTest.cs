using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Bridge;

namespace DesignPatternsTest
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void TestGetText()
        {
            string text = "Testing";
            string formattedText = "\"Testing\"";
            IImplementor implementor = new Implementor();
            IAbstraction abstraction = new Abstraction(implementor);

            string getFormattedText = abstraction.FormatText(text);

            Assert.AreEqual(formattedText, getFormattedText);
        }
    }
}