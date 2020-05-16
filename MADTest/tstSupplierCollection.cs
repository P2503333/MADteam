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
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            List<clsSuppliers> TestList = new List<clsSuppliers>();

            clsSuppliers TestItem = new clsSuppliers();

            TestItem.ID = 1;
            TestItem.Address = "Test Address";
            TestItem.Email = "test.email@data.com";
            TestItem.Name = "Test Name";
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Active = true;

            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSuppliers TestItem = new clsSuppliers();

            TestItem.ID = 1;
            TestItem.Address = "Test Address";
            TestItem.Email = "test.email@data.com";
            TestItem.Name = "Test Name";
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Active = true;

            AllSuppliers.ThisSupplier = TestItem;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            List<clsSuppliers> TestList = new List<clsSuppliers>();

            clsSuppliers TestItem = new clsSuppliers();

            TestItem.ID = 1;
            TestItem.Address = "Test Address";
            TestItem.Email = "test.email@data.com";
            TestItem.Name = "Test Name";
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Active = true;

            TestList.Add(TestItem);

            AllSuppliers.SupplierList = TestList;

            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection Suppliers = new clsSupplierCollection();

            clsSuppliers Supplier1 = new clsSuppliers();

            Int32 PrimaryKey = 1;

            Supplier1.Active = true;
            Supplier1.Address = "64 Zoo Lane";
            Supplier1.Email = "test.data@email.com";
            Supplier1.LastDelivery = DateTime.Now.Date;
            Supplier1.Name = "WotC";
            Supplier1.ID = PrimaryKey;

            Suppliers.ThisSupplier = Supplier1;
            PrimaryKey = Suppliers.Add();

            Suppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(Suppliers.ThisSupplier, Supplier1);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection Suppliers = new clsSupplierCollection();

            clsSuppliers Supplier1 = new clsSuppliers();

            Int32 PrimaryKey = 0;

            Supplier1.Active = true;
            Supplier1.Address = "64 Zoo Lane";
            Supplier1.Email = "test.data@email.com";
            Supplier1.LastDelivery = DateTime.Now.Date;
            Supplier1.Name = "WotC";
            Supplier1.ID = PrimaryKey;

            Suppliers.ThisSupplier = Supplier1;
            PrimaryKey = Suppliers.Add();

            Supplier1.ID = PrimaryKey;
            Suppliers.ThisSupplier.Find(PrimaryKey);

            Suppliers.DeleteSupplier();
            Boolean Found = Suppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection Suppliers = new clsSupplierCollection();

            clsSuppliers Supplier1 = new clsSuppliers();

            Int32 PrimaryKey = 1;

            Supplier1.Active = true;
            Supplier1.Address = "64 Zoo Lane";
            Supplier1.Email = "test.data@email.com";
            Supplier1.LastDelivery = DateTime.Now.Date;
            Supplier1.Name = "WotC";
            Supplier1.ID = PrimaryKey;

            Suppliers.ThisSupplier = Supplier1;
            PrimaryKey = Suppliers.Add();

            Supplier1.ID = PrimaryKey;
            Suppliers.ThisSupplier.Find(PrimaryKey);

            Supplier1.ID = PrimaryKey;

            Supplier1.Active = true;
            Supplier1.Address = "65 Zoo Lane";
            Supplier1.Email = "test.data@email.org";
            Supplier1.LastDelivery = DateTime.Now.Date;
            Supplier1.Name = "Konami";
            Supplier1.ID = PrimaryKey;

            Suppliers.ThisSupplier = Supplier1;
            Suppliers.Update();
            Suppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(Suppliers.ThisSupplier, Supplier1);


        }

        [TestMethod]
        public void FilterMethodOK()
        {
            clsSupplierCollection Suppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.Filter("");
            Assert.AreEqual(Suppliers.Count, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void FilterMethodNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.Filter("xxxxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void FilterMethodTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.Filter("Test Data");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].ID != 2)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[1].ID != 3)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
