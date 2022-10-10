using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Singleton;

namespace DesignPatternsTest
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestInstance()
        {
            //inaccessible due to protected protection level
            //ISingleton singleton = new Singleton();
            ISingleton singleton = Singleton.Instance;
            ISingleton singleton1 = Singleton.Instance;

            Assert.IsInstanceOfType(singleton, typeof(Singleton));
            Assert.AreSame(singleton, singleton1);
        }
    }
}
