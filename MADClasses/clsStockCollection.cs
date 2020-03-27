using System;
using System.Collections.Generic;

namespace MADClasses
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList = new List<clsStock>();
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock aBook = new clsStock();
                aBook.ISBN = Convert.ToString(DB.DataTable.Rows[Index]["ISBN"]);
                aBook.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                aBook.Author = Convert.ToString(DB.DataTable.Rows[Index]["Author"]);
                aBook.StockLevel = Convert.ToInt32(DB.DataTable.Rows[Index]["StockLevel"]);
                aBook.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                aBook.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                aBook.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                aBook.OnOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["OnOrder"]);
                mStockList.Add(aBook);
                Index++;
            }
        }


        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //this comes later
            } 
}
        public clsStock ThisStock { get; set; }
    }
}