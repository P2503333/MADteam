using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstSuppliers
    {
        string ID = "0";
        string Name = "Wizards of the Coast";
        string Email = "maro@wotc.com";
        string Address = "Ravnica";
        string LastDelivery = DateTime.Now.Date.ToString();


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

        //Testing that the validate method works
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            Error = Supplier1.Valid(ID, Name, Address, Email, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing ID's extreme min
        [TestMethod]
        public void IDExtremeMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = "-1000";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing ID's min - 1
        [TestMethod]
        public void IDMinMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = "-1";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing ID's min
        [TestMethod]
        public void IDMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = "0";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }
        
        //Testing ID's min + 1
        [TestMethod]
        public void IDMinPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = "1";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }
        
        //Testing ID's max - 1
        [TestMethod]
        public void IDMaxMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = Convert.ToString(int.MaxValue-1);
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }
        
        //Testing ID's max
        [TestMethod]
        public void IDMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = Convert.ToString(int.MaxValue);
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }
        
        //Testing ID's max + 1
        [TestMethod]
        public void IDMaxPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = Convert.ToString(Convert.ToInt64(int.MaxValue)+1);
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }
        
        //Testing ID's invalid data
        [TestMethod]
        public void IDInvalid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string ID = "Hello";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Name's min - 1
        [TestMethod]
        public void NameMinMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Name's min
        [TestMethod]
        public void NameMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "0";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Name's min + 1
        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "01";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Name's max - 1
        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "0123456789012345678901234567890123456789012345678";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Name's max
        [TestMethod]
        public void NameMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "01234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Name's max + 1
        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "012345678901234567890123456789012345678901234567890";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Name's mid
        [TestMethod]
        public void NameMid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "0123456789012345678901234";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Name's extreme max
        [TestMethod]
        public void NameExtremeMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Name = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Email's min - 1
        [TestMethod]
        public void EmailMinMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Email's min
        [TestMethod]
        public void EmailMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "0";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Email's min + 1
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "01";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Email's max - 1
        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "0123456789012345678901234567890123456789012345678";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Email's max
        [TestMethod]
        public void EmailMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "01234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Email's max + 1
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "012345678901234567890123456789012345678901234567890";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Email's mid
        [TestMethod]
        public void EmailMid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "0123456789012345678901234";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Email's extreme max
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Email = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Address's min - 1
        [TestMethod]
        public void AddressMinMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Address's min
        [TestMethod]
        public void AddressMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "0";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Address's min + 1
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "01";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Address's max - 1
        [TestMethod]
        public void AddressMaxMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Address's max
        [TestMethod]
        public void AddressMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing Address's max + 1
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Address's mid
        [TestMethod]
        public void AddressMid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Address's extreme max
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string Address = "012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing LastDelivery's extreme min
        [TestMethod]
        public void LastDeliveryExtremeMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "1/1/1000";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing LastDelivery's min - 1
        [TestMethod]
        public void LastDeliveryMinMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "31/12/1899";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing LastDelivery's min
        [TestMethod]
        public void LastDeliveryMin()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "1/1/1900";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing LastDelivery's min + 1
        [TestMethod]
        public void LastDeliveryMinPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "2/1/1900";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing LastDelivery's max - 1
        [TestMethod]
        public void LastDeliveryMaxMinusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "30/12/2099";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing LastDelivery's max
        [TestMethod]
        public void LastDeliveryMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "31/12/2099";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing LastDelivery's max + 1
        [TestMethod]
        public void LastDeliveryMaxPlusOne()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "1/1/2100";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing LastDelivery's mid
        [TestMethod]
        public void LastDeliveryMid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "1/1/2050";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreEqual(Error, "");
        }

        //Testing LastDelivery's extreme max
        [TestMethod]
        public void LastDeliveryExtremeMax()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "1/1/3000";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }

        //Testing LastDelivery's extreme min
        [TestMethod]
        public void LastDeliveryInvalid()
        {
            clsSuppliers Supplier1 = new clsSuppliers();
            String Error = "";
            string LastDelivery = "Yesterday";
            Error = Supplier1.Valid(ID, Name, Email, Address, LastDelivery);
            Assert.AreNotEqual(Error, "");
        }
    }
}
