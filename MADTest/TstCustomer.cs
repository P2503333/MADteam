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
    }
}
