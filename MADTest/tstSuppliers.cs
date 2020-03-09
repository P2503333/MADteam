using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstSuppliers
    {

        string Name = "Wizards of the Coast";
        string Email = "maro@wotc.com";
        string Address = "Ravnica";
        DateTime LastDelivery = DateTime.Now.Date;
        Boolean Active = true;


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
            string TestData = "Test Name";
            Supplier1.Name = TestData;
            Assert.AreEqual(Supplier1.Name, TestData);
        }

        //Testing the Address property
        [TestMethod]
        public void AddressPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            string TestData = "69 Zoo Lane";
            Supplier1.Address = TestData;
            Assert.AreEqual(Supplier1.Address, TestData);
        }

        //Testing the LastDelivery property
        [TestMethod]
        public void LastDeliveryPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            DateTime TestData = DateTime.Now;
            Supplier1.LastDelivery = TestData;
            Assert.AreEqual(Supplier1.LastDelivery, TestData);
        }

        //Testing the Email property
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            string TestData = "email@address.com";
            Supplier1.Email = TestData;
            Assert.AreEqual(Supplier1.Email, TestData);
        }

        //Testing the SupplierID property
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            int TestData = 0;
            Assert.AreEqual(Supplier1.ID, TestData);
        }

        //Testing the find method
        [TestMethod]
        public void FindMethodOk()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            int ID = 1;
            Console.WriteLine("ID 5 is " + Supplier1.Find(ID));
            bool Found = Supplier1.Find(ID);
            Console.WriteLine("Found var is " + Found);
            Assert.IsTrue(Found);
        }

        //Testing finding the supplier ID
        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.ID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Testing finding the supplier active property
        [TestMethod]
        public void TestSupplierActiveFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Testing finding the supplier delivery
        [TestMethod]
        public void TestSupplierDeliveryFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.LastDelivery != Convert.ToDateTime("10/10/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Testing finding the supplier email
        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.Email != "dc@dccomics.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Testing finding the supplier name
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.Name != "DC")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //Testing finding the supplier address
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            bool Found = false;
            bool OK = true;
            int ID = 5;
            Found = Supplier1.Find(ID);
            if (Supplier1.Address != "432 Fourth Avenue")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            Error = Supplier1.Valid(Name, Address, Email, LastDelivery, Active);
            Assert.AreEqual(Error, "");
        }
    }
}
