using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.TemplateMethod;

namespace DesignPatternsTest
{
    [TestClass]
    public class TemplateMethodTest
    {
        [TestMethod]
        public void TestTemplateMethod()
        {
            IClass @class = new ConcreteClass();

            Assert.AreEqual("hello", @class.TemplateMethod("hello"));
            Assert.AreEqual("hello~0*5", @class.TemplateMethod("hello00000"));
            Assert.AreEqual("hello \\w", @class.TemplateMethod("hello with"));
            Assert.AreEqual("hello \\w ~0*7", @class.TemplateMethod("hello with 0000000"));
        }
    }
}