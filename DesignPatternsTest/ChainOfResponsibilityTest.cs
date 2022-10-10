using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.ChainOfResponsibility;

namespace DesignPatternsTest
{
    [TestClass]
    public class ChainOfResponsibilityTest
    {
        [TestMethod]
        public void TestHandleRequest()
        {
            IHandler handlerA = new HandlerA();
            IHandler handlerB = new HandlerB(handlerA);
            IHandler handlerC = new HandlerC(handlerB);

            Assert.AreEqual("A", handlerA.HandleRequest());
            Assert.AreEqual("A", handlerB.HandleRequest());
            Assert.AreEqual("A", handlerC.HandleRequest());
        }
    }
}
