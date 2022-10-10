using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Command;

namespace DesignPatternsTest
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void TestCommand()
        {
            IInvoker invoker = new Invoker();
            IReceiver receiver = new Receiver();
            ICommand command = new Command(receiver.Action);

            invoker.StoreCommand(command);

            Assert.AreEqual(string.Empty, ((Receiver)receiver).GetText());

            invoker.InvokeCommands();

            Assert.AreEqual("a", ((Receiver)receiver).GetText());

            invoker.InvokeCommands();

            Assert.AreEqual("aa", ((Receiver)receiver).GetText());
        }
    }
}
