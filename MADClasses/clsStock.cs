using System;

namespace MADClasses
{
    public class clsStock
    {
        private string mISBN;
        public string ISBN {
            get
            {
                return mISBN;
            } 
            set
            {
                mISBN = value;
            } 
        }
        
        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        
        private int mSupplierID;
        public int SupplierID 
        { get
            {
                return mSupplierID;
            }
            set 
            {
                mSupplierID = value;
            }
        }

        private int mStockLevel;
        public int StockLevel
        {
            get 
            {
                return mStockLevel;
            }
            set 
            {
                mStockLevel = value;
            }
        }

        private string mBookName;
        public string BookName
        {
            get
            {
                return mBookName;
            }
            set
            {
                mBookName = value;
            }
        }

        private DateTime mReleaseDate;
        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }

        private Boolean mOnOrder;
        public Boolean OnOrder
        {
            get
            {
                return mOnOrder;
            }
            set
            {
                mOnOrder = value;
            }
        }

        private string mAuthor;
        public string Author
        {
            get
            {
                return mAuthor;
            }
            set
            {
                mAuthor = value;
            }
        }
        public bool Find(string ISBN) {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter of the ISBN to search
            DB.AddParameter("@ISBN", ISBN);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByISBN");
           //if one record is found
           if (DB.Count == 1)
            {
                //copy the data across to the private fields
                mISBN = Convert.ToString(DB.DataTable.Rows[0]["ISBN"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                mBookName = Convert.ToString(DB.DataTable.Rows[0]["BookName"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mOnOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["OnOrder"]);
                mAuthor = Convert.ToString(DB.DataTable.Rows[0]["Author"]);
                //return true to indicate success
                return true;
            }
           //if nothing is found
           else
            {
                //return false to show an error
                return false;
            }
        }
    }
}