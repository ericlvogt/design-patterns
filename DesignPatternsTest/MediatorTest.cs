using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Mediator;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatternsTest
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void TestIterator()
        {
            IMediator mediator = new Mediator();
            IColleague receiver = new OtherColleague();
            IColleague sender = new Colleague(mediator);

            mediator.AddReceiver(receiver);
            ((Colleague)sender).AddToOtherColleagues(5);

            Assert.AreEqual(5, receiver.GetValue());
            ((Colleague)sender).AddToOtherColleagues(-3);
            Assert.AreEqual(2, receiver.GetValue());
        }
    }
}
