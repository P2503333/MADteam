using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOk() 
        {
            ClsCustomer customer = new ClsCustomer();

            Assert.IsNull(customer);
        }

        [TestMethod]
        public void CustomerPropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            int test = 1;

            customer.CustomerId = test;

            Assert.AreEqual(customer.CustomerId, test);
        }

        [TestMethod]
        public void UsernamePropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            string test = "test";

            Assert.AreEqual(customer.Username, test);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            string test = "test";

            Assert.AreEqual(customer.Password, test);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            string test = "test";

            Assert.AreEqual(customer.Adress, test);
        }

        [TestMethod]
        public void DatePropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            DateTime test = DateTime.Now.Date;

            customer.JoinDate = test;

            Assert.AreEqual(customer.JoinDate, test);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            ClsCustomer customer = new ClsCustomer();
            bool test = true;

            customer.Active = test;

            Assert.AreEqual(customer.Active, test);
        }



                    [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernameNotFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Username != "Bob")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Password != "12345")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Adress != "Rutland Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestJoinDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(Join.Date);
            //check the property
            if (ACustomer.Join.Date != "02/08/1996")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}




        