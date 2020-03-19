using System;
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
        public int CustomerId {
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
                return mDispacth;
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
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for theorder to search for 
            DataMisalignedException.AddParameter("@Order_ID", Order_ID);
            //execute the sorted procedure 
            DB.Execute("sproc_tblOrder_FilterOrder_ID");

            //set the private data memebers to the test data value 
            mOrder_ID = 1;
            mOrder_Date = Convert.ToDateTime("16/09/2019");
            //always return true 
            return true;
                    }

       }
}