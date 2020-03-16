using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()

        {
            // an instance of the class 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists 
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        
        public void  TestOrder_ID()
        {
            //an instance of the class
            clsOrder AnOrder = new clsOrder();

            //test data 
            int TestData = 1;

            //assigning datato the property 
            AnOrder.Order_ID = TestData;

            //test 
            Assert.AreEqual(AnOrder.Order_ID, TestData);

            }

        [TestMethod]

        public void TestCustomerId()
        {
            //an instance of the class
            clsOrder AnOrder = new clsOrder();

            //test data 
            int TestData = 1;

            //assigning data to the property
            AnOrder.CustomerId = TestData;

            //test 
            Assert.AreEqual(AnOrder.CustomerId, TestData);

        }

        [TestMethod]
        public void Testemp_ID()
        {

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            int TestData = 1;

            //assigning data to the property 
            AnOrder.emp_ID = TestData;

            //test 
            Assert.AreEqual(AnOrder.emp_ID, TestData);

        }

        [TestMethod]
        public void TestQuantity()
        {  

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            int TestData = 1;

            //assigning data to the property 
            AnOrder.Quantity = TestData;

            //test 
            Assert.AreEqual(AnOrder.Quantity, TestData);

        }

        [TestMethod]
        public void TestTotalAmount()
        {

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            float TestData = 1;

            //assigning data to the property 
            AnOrder.TotalAmount = TestData;

            //test 
            Assert.AreEqual(AnOrder.TotalAmount, TestData);

        }

        [TestMethod]
        public void TestOrder_Date()
        {

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            DateTime TestData = DateTime.Now;

            //assigning data to the property 
            AnOrder.Order_Date = TestData;

            //test 
            Assert.AreEqual(AnOrder.Order_Date, TestData);

        }

        [TestMethod]
        public void TestDispatch()
        {

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
           Boolean TestData = true;

            //assigning data to the property 
            AnOrder.Dispatch = TestData;

            //test 
            Assert.AreEqual(AnOrder.Dispatch, TestData);
        

        }
        public void TestISBN()
            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            String TestData = 1;
        
            //assigning data to the property 
            AnOrder.ISBN = TestData;

            //test 
            Assert.AreEqual(AnOrder.ISBN, TestData);
    }
}
