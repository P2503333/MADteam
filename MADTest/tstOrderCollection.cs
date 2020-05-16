using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;



namespace MADTest
{
    [TestClass]
    public class ttstOrderCollection
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
            clsOrderCollection AllOrders = new clsOrderCollection();

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
            TestItem.Quantity = 100 ;
            TestItem.TotalAmount = 110;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1";

            //add the Item to the test list 
            TestList.Add(TestItem);
            //assign the date to the property 
            AllOrders.OrderList = TestList;
            //test to see that thetwo values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList );
        }
        [TestMethod]
        public void CountOrderOK()
        {
            //create an instance of the class 
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property 
            Int32 SomeCount = 102;
            //assign the data to the property 
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property 
          clsOrder TestOrder = new clsOrder();
            //set the properties of the test object 
            //set its properties 
            TestOrder.Order_ID = 1;
            TestOrder.CustomerId = 1;
            TestOrder.emp_ID = 1;
            TestOrder.Quantity = 100;
            TestOrder.TotalAmount = 110;
            TestOrder.Order_Date = DateTime.Now.Date;
            TestOrder.Dispatch = true;
            TestOrder.ISBN = "1";

            //assign the date to the property 
            AllOrders.ThisOrder = TestOrder;
            //test to see that thetwo values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
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
            TestItem.Quantity = 100;
            TestItem.TotalAmount = 110;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1";

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
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.CustomerId = 1;
            TestItem.emp_ID = 1;
            TestItem.Quantity = 100;
            TestItem.TotalAmount = 110;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1";

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrders.Add();

            //set the primary key of the test data
            TestItem.Order_ID = PrimaryKey;

            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }  
        
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key 
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.CustomerId = 1;
            TestItem.emp_ID = 1;
            TestItem.Quantity = 100;
            TestItem.TotalAmount = 110;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            Primarykey = AllOrders.Add();
            //set the key of the test data 
            TestItem.Order_ID = Primarykey;
            //find the record
            AllOrders.ThisOrder.Find(Primarykey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(Primarykey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.CustomerId = 1;
            TestItem.emp_ID = 1;
            TestItem.Quantity = 100;
            TestItem.TotalAmount = 110;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1";

            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test
            TestItem.Order_ID = PrimaryKey;
            //modify the test data 
            TestItem.Order_ID = 107;
            TestItem.CustomerId = 277;
            TestItem.emp_ID = 277;
            TestItem.Quantity = 77;
            TestItem.TotalAmount = 77;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "77";
            //set the record based on the new test data 
            AllOrders.ThisOrder = TestItem;
            //update the record 
            AllOrders.Update();
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]

        public void ReportByQuantityMethodOK()
        {
          //create an instance of the class containing unfilteres results
          clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records );
            FilteredOrders.ReportByQuantity(0);
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByQuantityNoneFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a Quantity that doesn't exist 
            FilteredOrder.ReportByQuantity(0);
            Assert.AreEqual(0,FilteredOrder.count);

        }
        
        [TestMethod]
        public void RepotByQuantityTestDataFound()
        {
            //create an instance of the filtered data 
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply  a quantity that doesn't exist 
            FilteredOrder.ReportByQuantity(100);
            //check that the correct number of records are found
            if(FilteredOrder.Count ==2)
            {
                //check that the first record is ID 102
                if(FilteredOrder.OrderList[0].Order_ID != 102)
                {
                    OK = false;
                }
                //check that the first record is ID 103
                if (FilteredOrder.OrderList[1].Order_ID != 103)
                {
                    OK = false;

                }
                else
                {
                    OK = false;

                }
                //test to see that there are no records 
                Assert.IsTrue(OK);
            }

        }
    }

}

