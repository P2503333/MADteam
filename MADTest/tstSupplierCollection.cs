using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MADTest
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.Active = true;
            TestItem.Address = "123 WotC Lane";
            TestItem.Email = "wotc@wotc.com";
            TestItem.ID = 10;
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Name = "WotC";
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSuppliers.Count = SomeCount;
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSuppliers TestSupplier = new clsSuppliers();
            TestSupplier.Active = true;
            TestSupplier.Address = "123 WotC Lane";
            TestSupplier.Email = "wotc@wotc.com";
            TestSupplier.ID = 10;
            TestSupplier.LastDelivery = DateTime.Now.Date;
            TestSupplier.Name = "WotC";

            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.Active = true;
            TestItem.Address = "123 WotC Lane";
            TestItem.Email = "wotc@wotc.com";
            TestItem.ID = 10;
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Name = "WotC";
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
    }
}
