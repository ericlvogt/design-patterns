using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.State;

namespace DesignPatternsTest
{
    [TestClass]
    public class StateTest
    {
        [TestMethod]
        public void TestState()
        {
            IContext context = new Context();
            context.SetTime(5);

            Assert.IsTrue(context.ShouldITurnLightsOn());
            context.SetTime(8);
            Assert.IsFalse(context.ShouldITurnLightsOn());
        }
    }
}