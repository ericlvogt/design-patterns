using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Flyweight;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatternsTest
{
    [TestClass]
    public class FlyweightTest
    {
        [TestMethod]
        public void TestFlyweight()
        {
            IFlyweightFactory flyweightFactory = new FlyweightFactory();
            Dictionary<IFlyweightContext, IFlyweight> list = new();

            list.Add(new FlyweightContext(1), flyweightFactory.CreateFlyweight(1));
            list.Add(new FlyweightContext(2), flyweightFactory.CreateFlyweight(1));
            list.Add(new FlyweightContext(3), flyweightFactory.CreateFlyweight(6));
            list.Add(new FlyweightContext(4), flyweightFactory.CreateFlyweight(6));

            IFlyweightContext flyweightContext = list.Keys.First(key => key.Index == 1);
            IFlyweight flyweight = list[flyweightContext];

            Assert.AreSame(list.First(kvp => kvp.Key.Index == 1).Value, list.First(kvp => kvp.Key.Index == 2).Value);
            Assert.AreEqual("Index1Size1", flyweight.GetIndexAndSize(flyweightContext));
            Assert.AreNotSame(list.First(kvp => kvp.Key.Index == 3).Value, list.First(kvp => kvp.Key.Index == 4).Value);
        }
    }
}
