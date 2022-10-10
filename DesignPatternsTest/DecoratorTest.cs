using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Decorator;

namespace DesignPatternsTest
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void TestGetText()
        {
            string text = "Testing";
            string formattedText = "\"Testing\"";
            IComponent component = new Component(text);
            IComponent decoratedComponent = new QuotationDecorator(component);

            Assert.AreEqual(text, component.GetText());
            Assert.AreEqual(formattedText, decoratedComponent.GetText());
        }
    }
}