using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstOrder
    {
        public object Found { get; set; }

        [TestMethod]
        public void InstanceOK()

        {
            // an instance of the class 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists 
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]

        public void TestOrder_ID()
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


        [TestMethod]
        public void TestISBN()
        {

            //an instance of the class 
            clsOrder AnOrder = new clsOrder();

            //test data 
            string TestData = "1111111111111";

            //assigning data to the property 
            AnOrder.ISBN = TestData;

            //test 
            Assert.AreEqual(AnOrder.ISBN, TestData);


        }

        [TestMethod]
        public void FindMethodOK()
        {

            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // boolean Variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            int Order_ID = 1;
            // invoke the method 
            Found = AnOrder.Find(Order_ID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrder_IDFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.Order_ID != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCustomerIdFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);

        }
        public void Testemp_IDFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.emp_ID != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.Quantity != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.TotalAmount != 1)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void TestOrder_DateFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            //invoke the method
            Found = AnOrder.Find(Order_ID);

            //check the property
            if (AnOrder.Order_Date != Convert.ToDateTime("16/09/2019"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDispatchFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.Dispatch != true)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestISBNFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            Boolean OK = true;
            int Order_ID = 1;

            Found = AnOrder.Find(Order_ID);
            if (AnOrder.ISBN != " 1111111111111") 
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
 
