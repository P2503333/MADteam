﻿using System;
using System.Linq;
using System.Text;




namespace MADClasses
{
    public class clsOrder
    {
        //Order_ID private member variable 
        private int mOrder_ID;

        //order-ID public property 
        public int Order_ID
        {
            get
            {
                //this line of code sends data out of the property 
                return mOrder_ID;
            }
            set
            {
                //this line of the code alloows data into the property 
                mOrder_ID = value;

            }

        }
        private int mCustomerId;
        //public property for customer id 
        public int CustomerId
        {
            get
            {
                //this line of code send data out of property 
                return mCustomerId;
            }

            set
            {
                //this line of the code allows data into the property
                mCustomerId = value;
            }
        }

        private int memp_ID;
        //public property for employee id
        public int emp_ID
        {
            get
            {
                //this line of code send data out of property 
                return memp_ID;
            }

            set
            {
                //this line of the code allows data into the property
                memp_ID = value;
            }
        }
        private int mQuantity;

        public int Quantity
        {
            get
            {
                //this line of code send data out of property 
                return mQuantity;
            }

            set
            {
                //this line of the code allows data into the property
                mQuantity = value;
            }
        }
        private float mTotalAmount;

        public float TotalAmount
        {
            get
            {
                //this line of code send data out of property 
                return mTotalAmount;
            }

            set
            {
                //this line of the code allows data into the property
                mTotalAmount = value;
            }
        }
        private DateTime mOrder_Date;
        public DateTime Order_Date
        {
            get
            {
                return mOrder_Date;

            }
            set
            {
                mOrder_Date = value;
            }
        }
        private bool mDispatch;
        public bool Dispatch
        {
            get
            {
                //this line of code send data out of property 
                return mDispatch;
            }

            set
            {
                //this line of the code allows data into the property
                mDispatch = value;
            }
        }
        private string mISBN;

        public string ISBN
        {
            get
            {
                //this line of code send data out of property 
                return mISBN;
            }

            set
            {
                //this line of the code allows data into the property
                mISBN = value;
            }
        }

        // public int mOrder_ID { get; private set; }

        public bool Find(int Order_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the orderid to search for 
            DB.AddParameter("@Order_ID", Order_ID);
            //DataMisalignedException.AddParameter("@Order_ID", Order_ID);

            //execute the sorted procedure 
            DB.Execute("sproc_tblOrder_FilterOrder_ID");

            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //set the private data memebers to the test data value
                mOrder_ID = Convert.ToInt(DB.DataTable.Rows[0]["Order_ID"]);
                mCustomerId = Convert.ToInt(DB.DataTable.Rows[0]["CustomerId"]);
                memp_ID = Convert.ToInt(DB.DataTable.Rows[0]["emp_ID"]);
                mQuantity = Convert.ToInt(DB.DataTable.Rows[0]["Quantity"]);
                mTotalAmount = Convert.ToInt(DB.DataTable.Rows[0]["TotalAmount"]);
                mOrder_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                mDispatch = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatch"]);
                mISBN = Convert.ToString(DB.DataTable.Rows[0]["ISBN"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return true;

            }
        }
        //function for the public validation method
        public string valid(int order_ID, int customerId, int emp_ID, int quantity, float totalAmount, DateTime order_Date, bool dispatch, string iSBN)
        {
            //create a string variable to store the error
            String Error = "";
            //if the Order_ID is blank 
            if (Order_ID == 0)
            {
                //record the error
                Error = Error + "the Order ID may not be blank :";
            }
            //if the order id number is greater  10000
            if (Order_ID > 10000)
            {
                //record the error 
                Error = Error + "the order id must be less than 10000 :";

            }
            //copy the Order_Date value to the DateTemp variable
            DateTemp = Convert.ToDateTime(Order_Date);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The date cannot be in the past:";

            }
            // check to see if the date is greater than today's date 
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The data cannot be in the future : ";

            }
            //return any error message 
            return Error;
        }

        public string valid(int order_ID, int customerId, int emp_ID, int quantity, float totalAmount, string order_Date, bool dispatch, string iSBN)
        {
            throw new NotImplementedException();
        }
    }
}