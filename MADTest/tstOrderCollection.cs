using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MADTest
{
    [TestClass]
    public class tstOrderCollection
    {
        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class 
            clsOrderCollection AllOrder = new clsOrderCollection();

            //create some test data to assign to the property 
            //in this case the data needs to be a  list of objects #
            List<clsOrder> TestList = new List<clsOrder>();

            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();

            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.CustomerId = 1;
            TestItem.emp_ID = 1;
            TestItem.Quantity = 1;
            TestItem.TotalAmount = 1;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "111111111111";

            //add the Item to the test list 
            TestList.Add(TestItem);
            //assign the date to the property 
            AllOrders.OrderList = TestList;
            //test to see that thetwo values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void CountOrderOK()
        {
            //create an instance of the class 
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property 
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property 
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object 
            //set its properties 
            TestOrder.Order_ID = 1;
            TestOrder.CustomerId = 1;
            TestOrder.emp_ID = 1;
            TestOrder.Quantity = 1;
            TestOrder.TotalAmount = 1;
            TestOrder.Order_Date = DateTime.Now.Date;
            TestOrder.Dispatch = true;
            TestOrder.ISBN = "111111111111";

            //assign the date to the property 
            AllOrders.ThisOrder = TestOrder;
            //test to see that thetwo values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property 
            //in this case the date needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();

            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();

            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.CustomerId = 1;
            TestItem.emp_ID = 1;
            TestItem.Quantity = 1;
            TestItem.TotalAmount = 1;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "111111111111";

            //add the item to the test list 
            TestList.Add(TestItem);

            //assign the data to the property 
            AllOrders.OrderList = TestList;

            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
         }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //crestr the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key 
            Int32 PrimaryKey = 1;
            //set its properties 
            TestOrder.Order_ID = 1;
            TestOrder.CustomerId = 1;
            TestOrder.emp_ID = 1;
            TestOrder.Quantity = 1;
            TestOrder.TotalAmount = 1;
            TestOrder.Order_Date = DateTime.Now.Date;
            TestOrder.Dispatch = true;
            TestOrder.ISBN = "111111111111";

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.Order_ID = PrimaryKey;

            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrders, TestItem);
        }              
    }

}

