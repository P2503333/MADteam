


using System;
using System.Collections.Generic;

namespace MADClasses
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private date member ThisOrder
        clsOrder mThisOrder = new clsOrder();


        
        //public property for the Order List
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;

            }
        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the line 
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later

            }

        }
        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the pricate data 
                mThisOrder = value;
            }

        }
        //constructor for the class 
        public clsOrderCollection()
        {
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
            mOrderList.Add(TestItem);
            //re initalisa the object for some new data
            TestItem = new clsOrder();
            ////create the item of test data 
            clsOrder TestItem = new clsOrder();

            //set its properties 
            TestItem.Order_ID = 10;
            TestItem.CustomerId = 2;
            TestItem.emp_ID = 4;
            TestItem.Quantity = 5;
            TestItem.TotalAmount = 45;
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Dispatch = true;
            TestItem.ISBN = "1111111111";
            ;
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //set the primary key value of the new record
            mThisOrder.Order_ID = 1;
            //return the primary key of the new record
            return mThisOrder.Order_ID;
        }
    }
}