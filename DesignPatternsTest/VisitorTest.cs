using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Visitor;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsTest
{
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void TestTemplateMethod()
        {
            IElement elementA = new ElementA();
            List<IElement> elements = new List<IElement>();
            IVisitor visitor = new Visitor();

            for(int i = 1; i < 5; i++)
            {
                elements.Add(new ElementB(i, 1));
            }
            ((ElementA)elementA).Price = 10.50f;

            elementA.Accept(visitor);

            Assert.AreEqual(10.50f, ((Visitor)visitor).TotalPrice);

            elements.ForEach(e => e.Accept(visitor));

            Assert.AreEqual(20.50f, ((Visitor)visitor).TotalPrice);
        }
    }
}