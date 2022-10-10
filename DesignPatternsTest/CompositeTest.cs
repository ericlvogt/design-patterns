using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Composite;

namespace DesignPatternsTest
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void TestAddAndRemoveComponent()
        {
            string text = "Testing";
            IComposite composite = new Composite();
            IComponent leaf = new Leaf(text);
            
            composite.Add(leaf);

            Assert.IsTrue(composite.GetChildren().Contains(leaf));
            Assert.AreEqual(1, composite.GetChildren().Count);

            composite.Remove(leaf);
            Assert.IsFalse(composite.GetChildren().Contains(leaf));
            Assert.AreEqual(0, composite.GetChildren().Count);
        }

        [TestMethod]
        public void TestGetText()
        {
            IComposite composite = new Composite();
            IComponent leaf1 = new Leaf("Leaf1");
            IComponent leaf2 = new Leaf("Leaf2");

            composite.Add(leaf1);
            composite.Add(leaf2);

            Assert.AreEqual("Leaf1", leaf1.GetText());
            Assert.AreEqual("Leaf2", leaf2.GetText());
            Assert.AreEqual("Leaf1Leaf2", composite.GetText());
        }

        [TestMethod]
        public void TestGetComposite()
        {
            IComponent composite = new Composite();
            IComponent leaf = new Leaf("Leaf");

            IComposite comp = composite.GetComposite();
            IComposite compLeaf = leaf.GetComposite();

            Assert.AreSame((IComposite)composite, comp);
            Assert.IsNull(compLeaf);
        }
    }
}
