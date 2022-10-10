using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Facade;
using System.Linq;

namespace DesignPatternsTest
{
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void TestGetValue()
        {
            ISubComponentNumber subComponentNumber = new SubComponentNumber();
            ISubComponentText subComponentText = new SubComponentText();
            IFacade facade = new Facade(subComponentNumber, subComponentText);

            subComponentNumber.Add(5);
            subComponentText.Add("test");

            Assert.AreEqual("test", subComponentText.GetText().First());
            Assert.AreEqual("test", facade.GetText().First());
            Assert.AreEqual(5, subComponentNumber.GetValue());
            Assert.AreEqual(5, facade.GetNumber());
        }
    }
}
