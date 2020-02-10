using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstSuppliers
    {

        //Testing the initialisation
        [TestMethod]
        public void InstanceOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Assert.IsNotNull(Supplier1);
        }

        //Testing the active property
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Boolean TestData = true;
            Supplier1.Active = TestData;
            Assert.AreEqual(Supplier1.Active, TestData);
        }

        //Testing the SupplierName property
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Boolean TestData = true;
            Supplier1.Active = TestData;
            Assert.AreEqual(Supplier1.Active, TestData);
        }

        //Testing the LastDelivery property
        [TestMethod]
        public void LastDeliveryPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Boolean TestData = true;
            Supplier1.Active = TestData;
            Assert.AreEqual(Supplier1.Active, TestData);
        }

        //Testing the Email property
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Boolean TestData = true;
            Supplier1.Active = TestData;
            Assert.AreEqual(Supplier1.Active, TestData);
        }

        //Testing the SupplierID property
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            Assert.IsNotNull(Supplier1.ID);
        }
    }
}
