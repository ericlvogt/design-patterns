using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Proxy;
using System;

namespace DesignPatternsTest
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void TestVirtualProxy()
        {
            int height = 3;
            int width = 4;
            ISubject subject = new Subject() { Height = height, Width = width };
            ISubject[] subjects = new ISubject[100];
            subjects[0] = subject;
            VirtualProxy virtualProxy = new VirtualProxy(0, subjects, width);

            Assert.IsFalse(virtualProxy.SubjectLoaded);
            Assert.AreEqual(width, virtualProxy.Width);
            Assert.IsFalse(virtualProxy.SubjectLoaded);
            Assert.AreEqual(height, virtualProxy.Height);
            Assert.IsTrue(virtualProxy.SubjectLoaded);
        }

        [TestMethod]
        public void TestRemoteProxy()
        {
            int height = 4;
            int width = 5;
            RemoteProxy remoteProxy = new RemoteProxy("address001");

            Assert.AreEqual(width, remoteProxy.Width);
            Assert.AreEqual(height, remoteProxy.Height);
        }

        [TestMethod]
        public void TestProtectionProxy()
        {
            int height = 4;
            int width = 5;
            ISubject subject = new Subject() { Width = width, Height = height };
            ISubject protectionProxyNoAccess = new ProtectionProxy(subject, ProtectionProxy.Access.NoAccess);
            ISubject protectionProxyReadOnly = new ProtectionProxy(subject, ProtectionProxy.Access.ReadOnly);
            ISubject protectionProxyFullAccess = new ProtectionProxy(subject, ProtectionProxy.Access.FullAccess);

            Assert.ThrowsException<AccessViolationException>(() => protectionProxyNoAccess.Height);
            Assert.ThrowsException<AccessViolationException>(() => protectionProxyNoAccess.Width);
            Assert.ThrowsException<AccessViolationException>(protectionProxyNoAccess.CostlyOperation);

            Assert.AreEqual(height, protectionProxyReadOnly.Height);
            Assert.AreEqual(width, protectionProxyReadOnly.Width);
            Assert.ThrowsException<AccessViolationException>(protectionProxyReadOnly.CostlyOperation);

            Assert.AreEqual(height, protectionProxyFullAccess.Height);
            Assert.AreEqual(width, protectionProxyFullAccess.Width);
            try
            {
                protectionProxyFullAccess.CostlyOperation();
            }
            catch(AccessViolationException e)
            {
                Assert.Fail();
            }
        }
    }
}
