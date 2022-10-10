using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Prototype;

namespace DesignPatternsTest
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void TestClone()
        {
            int initialListCount = 5;

            IPrototype prototype = new Prototype(initialListCount);
            IPrototype prototypeClone = prototype.Clone();
            prototypeClone.AddToList(7);

            Assert.IsInstanceOfType(prototypeClone, typeof(Prototype));
            Assert.AreNotSame(prototype, prototypeClone);
            Assert.AreNotSame(prototype.ListCount, prototypeClone.ListCount);
            Assert.AreEqual(5, prototype.ListCount);
            Assert.AreEqual(6, prototypeClone.ListCount);
        }
    }
}
