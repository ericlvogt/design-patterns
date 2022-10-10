using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Iterator;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatternsTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void TestIterator()
        {
            Aggregate<string> aggregate = new Aggregate<string>(10);
            IIterator<string> iterator = aggregate.CreateIterator();

            for(int i = 0; i < aggregate.Count; i++)
            {
                aggregate.SetItem(i, i.ToString());
            }

            int index = 0;
            for(iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                Assert.AreEqual(index++.ToString(), iterator.CurrentItem());
            }
        }
    }
}
