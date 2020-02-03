using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Assert.IsNotNull(Supplier1);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Boolean TestData = true;
            Supplier1.Active = TestData;
            Assert.AreEqual(Supplier1.Active, TestData);
        }
        //Test
    }
}
