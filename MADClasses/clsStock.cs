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
        private int mStockID;
        public int StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }

        //Written by David for the suppliers page
        public string SupplierInfo
        {
            get
            {
                return mBookName + ", " + mAuthor + ": " + mStockLevel;
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

        public string Valid(string iSBN, string price, string stockLevel, string bookName, string author, string supplierId, string releaseDate)
        {
            string Error = "";

            DateTime DateTemp;
            Double PriceTemp;
            int StockTemp;
            int SupplierTemp;
            string PriceDecimal;
            string[] datesplit;
            bool isbnNumbers;
            

            if (iSBN.Length == 0)
            {
                Error = Error + "The ISBN cannot be blank :";
            }
            if(iSBN.Length != 10 && iSBN.Length !=13 )
            {
                Error = Error +  "The ISBN must be either 10 or 13 digits long :";
            }
            isbnNumbers = true;
            foreach (char c in iSBN)
            {
                if (c< '0' ||  c> '9')
                {
                    isbnNumbers = false;
                }

            }
            if (isbnNumbers == false)
            {
                Error = Error + "a valid ISBN only contains numbers";
            }
            try
            {
                SupplierTemp = Convert.ToInt16(supplierId);
                if (SupplierTemp < 1)
                {
                    Error = Error + "The Supplier ID cannot be 0 or negative :";
                }
                if (SupplierTemp > 1000)
                {
                    Error = Error + "The Supplier ID cannot be greater than 1000 :";
                }

            }
            catch
            {
                Error = Error + "The entered Supplier ID value was not a valid integer :";
            }
            try
            {
                StockTemp = Convert.ToInt16(stockLevel);
                if (StockTemp < 0)
                {
                    Error = Error + "The stock level cannot be negative :";
                }
                if (StockTemp > 1000)
                {
                    Error = Error + "The stock level cannot be above 1000 :";
                }
            }
            catch
            {
                Error = Error + "The entered stock value was not a valid whole number :";
            }

            if (bookName.Length == 0)
            {
                Error = Error + "The book name cannot be blank :";
            }
            if (bookName.Length > 200)
            {
                Error = Error + "The book name cannot be longer than 200 characters :";
            }

            try
            {
                PriceTemp = Convert.ToDouble(price);
                if (PriceTemp < 0.01)
                {
                    Error = Error + "The price cannot be £0.00 or less :";
                }
                if (PriceTemp > 999999.99)
                {
                    Error = Error + "The price cannot be above £100,000,000 :";
                }
                if (price.Contains("."))
                {
                    string[] split = price.Split('.');
                    PriceDecimal = split[1];
                    if (PriceDecimal.Length != 2)
                    {
                        Error = Error + "The price decimal value must be exactly 2 digits :";
                    }
                }
            }
            catch
            {
                Error = Error + "The price value entered was not a valid number ;";
            }

           
      
            try
            {
                DateTemp = Convert.ToDateTime(releaseDate);
                if (DateTemp > Convert.ToDateTime("31/12/2099"))
                {
                    Error = Error + "The entered release date is too far in the future. Input a date earlier than 31/12/2099";
                }
                if (DateTemp < Convert.ToDateTime("1/1/1440") )
                {
                    Error = Error + "The entered release date is too early. Input a date later than 1/1/1440";
                }
            }
            catch
            {
                Error = Error + "The release date entered was not valid";
            }

           datesplit = releaseDate.Split('/');
            try
            {
                if (datesplit[2].Length != 4)
                {
                    Error = Error + "Please enter the year in full 4-digit format, eg 2019";
                }
            }
            catch
            {
                Error = Error + "The release date entered was not valid";
            }

            if (author.Length > 100)
            {
                Error = Error + "Maximum author name length is 100 characters";

            }
            if (author == "")
            {
                Error = Error + "Author field cannot be blank";
            }
            //on order test was here. Deemed unneccessary, add back later if needed?





            return Error;
        }
    }
}