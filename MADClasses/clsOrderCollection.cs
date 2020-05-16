
using System;
using System.Collections.Generic;
using System.Text;


namespace MADClasses
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private date member ThisOrder
        clsOrder mThisOrder = new clsOrder();
        public int count;

        //constructor for the clas
        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the arreay List with the data table
            PopulateArray(DB);

        }

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
        void PopulateArray(clsDataConnection DB)
        {
           //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = 0;    
            //get the count of records
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record 
                AnOrder.Order_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_ID"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.emp_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["emp_ID"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.TotalAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.Order_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order_Date"]);
                AnOrder.Dispatch = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatch"]);
                AnOrder.ISBN = Convert.ToString(DB.DataTable.Rows[Index]["ISBN"]);
                //add the record to the private data member 
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;

            }

        }


        public int Add()
        {
          //adds a new record to the database based on the values of ThisOrder
            
          //connect to the databse 
          clsDataConnection DB = new clsDataConnection();
            //set the parameters for the dtored procedure
            mThisOrder.Order_ID = 1;
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@emp_ID", mThisOrder.emp_ID);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@Order_Date", mThisOrder.Order_Date);
            DB.AddParameter("@Dispatch", mThisOrder.Dispatch);
            DB.AddParameter("@ISBN", mThisOrder.ISBN);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblOrder_Insert");
        }

      

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure 
            DB.AddParameter("@Order_ID", mThisOrder.Order_ID);
            //execute the stored procedure 
            DB.Execute("sproc-tblOrder_Delete");
        }
        public void Update()
        {
            //update an existing record based on the values of this Order
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_ID", mThisOrder.Order_ID);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@emp_ID", mThisOrder.emp_ID);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@Order_Date", mThisOrder.Order_Date);
            DB.AddParameter("@Dispatch", mThisOrder.Dispatch);
            DB.AddParameter("@ISBN", mThisOrder.ISBN);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Update");
        }  
        
         public void ReportByQuantity(int Quantity)
                {
            //filters the records based on a full or partial Quantity 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the parameter quantity to the database
            DB.AddParameter("@Quantity", Quantity);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByQuantity");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}