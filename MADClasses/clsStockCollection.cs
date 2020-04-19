using System;
using System.Collections.Generic;

namespace MADClasses
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList = new List<clsStock>();
        private clsStock mThisStock = new clsStock();
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
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public string Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ISBN", mThisStock.ISBN);
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@StockLevel", mThisStock.StockLevel);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Author", mThisStock.Author);
            DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
            DB.AddParameter("@OnOrder", mThisStock.OnOrder);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            return Convert.ToString(DB.Execute("sproc_tblStock_InsertInto"));
           
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ISBN", mThisStock.ISBN);
            DB.Execute("sproc_tblStock_delete");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ISBN", mThisStock.ISBN);
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@StockLevel", mThisStock.StockLevel);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Author", mThisStock.Author);
            DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
            DB.AddParameter("@OnOrder", mThisStock.OnOrder);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            DB.Execute("sproc_tblStock_Update");
        }
    }
}