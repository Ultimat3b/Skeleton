using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPayment Payment = new clsPayment();
            Assert.IsNotNull(Payment);
        }
    }
}
