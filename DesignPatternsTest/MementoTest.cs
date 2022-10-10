using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Memento;

namespace DesignPatternsTest
{
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void TestMemento()
        {
            Caretaker caretaker = new();
            Originator originator = new Originator();

            originator.Name = "Past";
            caretaker.StoreMemento(originator.CreateMemento());

            Assert.AreEqual("Past", originator.Name);

            originator.Name = "Present";

            Assert.AreEqual("Present", originator.Name);

            originator.SetMemento(caretaker.GetMemento());

            Assert.AreEqual("Past", originator.Name);
        }
    }
}
