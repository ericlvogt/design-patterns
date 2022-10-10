using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Observer;

namespace DesignPatternsTest
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void TestObserver()
        {
            Observer observer = new Observer();
            Subject subject = new Subject();

            subject.State = "First";
            subject.Attach(observer);

            Assert.AreEqual("First", subject.State);
            Assert.IsNull(observer.State);

            subject.State = "Second";
            Assert.AreEqual("Second", subject.State);
            Assert.AreEqual("Second", observer.State);
        }
    }
}