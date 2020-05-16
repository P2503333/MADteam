using System;
using System.Diagnostics.Tracing;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method 
       private readonly int CustomerId = 1;
       private readonly int emp_ID = 1;
       private readonly int Quantity = 100;
       private readonly float TotalAmount = 110;
       private readonly DateTime Order_Date = DateTime.Now.Date;
       private readonly bool Dispatch = true;
       private readonly string ISBN = "1111111111111";

        private readonly int Order_ID = 1;

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
            int TestData = 100;

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
            float TestData = 110;

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
            string TestData = "1";

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
            Boolean Ok = true;
            //create some test data to use with the method 
            int Order_ID = 1;
            // invoke the method 
            Found = AnOrder.Find(Order_ID);
            if (Found)
            {
                Ok = true;
            }
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestOrder_IDFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;

            //invoke the method
            Found = AnOrder.Find(Order_ID);

            // check the Order_ID 
            if (AnOrder.Order_ID != 1)
            {
                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCustomerIdFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method
            int Order_ID = 1;

            //invoke the method 
            Found = AnOrder.Find(Order_ID);

            //check the property 
            if (AnOrder.CustomerId != 1)
            {
                OK = false;

            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
        public void Testemp_IDFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method
            int Order_ID = 1;

            //invoke the method 
            Found = AnOrder.Find(Order_ID);

            //check the property 
            if (AnOrder.emp_ID != 1)
            {
                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable  to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;

            //invoke the method 
            Found = AnOrder.Find(Order_ID);

            //check the property 
            if (AnOrder.Quantity != 1)
            {
                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable  to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;

            //invoke the method 
            Found = AnOrder.Find(Order_ID);

            //check the property
            if (AnOrder.TotalAmount != 1)
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void TestOrder_DateFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable  to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;

            //invoke the method
            Found = AnOrder.Find(Order_ID);

            //check the property
            if (AnOrder.Order_Date != Convert.ToDateTime("16/09/2019"))
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDispatchFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;

            //invoke the method 
            Found = AnOrder.Find(Order_ID);

            //check the property 
            if (AnOrder.Dispatch != true)
            {
                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestISBNFound()
        {
            // create an Instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //boolean variable to store the result of the search 
            Boolean Found = false;

            //boolean variable to record 
            Boolean OK = true;

            //create some test data to use with the method 
            int Order_ID = 1;
            //invoke the method 

            Found = AnOrder.Find(Order_ID);

            //check the property 
            if (AnOrder.ISBN != "1111111111111")
            {
                OK = false;

            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = " ";
            //invoke the method 
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Order_IDMinLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 0; //this should trigger an error

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "the Order ID can not be less then null` :");
        }
        [TestMethod]
        public void Order_IDMinPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 2; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Order_IDMaxLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 9999; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Order_IDMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 10000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Order_IDMid()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 5000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Order_IDMaxPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 10001; //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Order_IDExtremeMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Order_ID = 1000000;           //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Order_DateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the data is less
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable 
            //string Order_Date = TestDate.ToString();

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "The data cannot be in the future : ");

        }

        [TestMethod]
        public void Order_DateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the data is less 1 day 
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable 
            // string Order_Date = TestDate.ToString();

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "The date cannot be in the past:");
        }
        [TestMethod]
        public void Order_DateMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable 
            // string Order_Date = TestDate.ToString();

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Order_DateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data 
            DateTime TestDate;

            //set the date totodays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the data is plus 1 day 
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable 
            //string Order_Date = TestDate.ToString();

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "The data cannot be in the future : ");
        }
        [TestMethod]
        public void Order_DateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error message 
            String Error = "";

            //create a variable to store the test date data 
            DateTime TestDate;

            //set the date totodays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the data is less
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable 
            //string Order_Date = TestDate.ToString();

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "The date cannot be in the past:");
        }
        //[TestMethod]
        //public void Order_DateInvalidData()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrder AnOrder = new clsOrder();

        //    //string variable to store any error message 
        //    String Error = "";

        //    //set the Order_Date to a non date vale 
        //    // string Order_Date = "this is not a date!";

        //    // invoke the method 
        //    Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);

        //    // test to see that the result is correct 
        //    Assert.AreNotEqual(Error, "");
        //}

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerId = 0;
            //invoke the method 
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 2; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 9999; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 10000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 5000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 10001; //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int CustomerId = 1000000;           //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void Emp_IDMinLessOne()

        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int emp_ID = 0;
            //invoke the method 
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Emp_IDMinPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 2; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Emp_IDMaxLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 9999; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Emp_IDMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 10000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Emp_IDMid()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 5000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Emp_IDMaxPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 10001; //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Emp_IDExtremeMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int emp_ID = 1000000;           //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //quantity test
        

        [TestMethod]
        public void QuantityMinLessOne()

        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int Quantity = 0;
            //invoke the method 
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 2; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 9999; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 10000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 5000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 10001; //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            int Quantity = 1000000;           //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TotalAmountMinLessOne()

        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int TotalAmount = 0;
            //invoke the method 
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 2; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 999999; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TotalAmountMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 999999;
                ; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TotalAmountMid()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 5000; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 100000; //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "the total amount must be less than 10000:");
        }

        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            //create an instances of the class we want to create 
            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message
            String Error = "error";

            //create some test data to pass to the method
            float TotalAmount = 110000;           //this should fail

            //invoke the method
            Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "the total amount must be less than 10000:");

        }
       

    }
}
 
