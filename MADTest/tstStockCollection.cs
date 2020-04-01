using System;
using System.Collections.Generic;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStockCollection allStock = new clsStockCollection();
            Assert.IsNotNull(allStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock aBook = new clsStock();
            aBook.ISBN = "0385603428";
            aBook.BookName = "Going Postal";
            aBook.Author = "Terry Pratchett";
            aBook.OnOrder = false;
            aBook.StockLevel = 100;
            aBook.Price = 9.99;
            aBook.SupplierID = 1;
            aBook.ReleaseDate = Convert.ToDateTime("25/9/2004");
            TestList.Add(aBook);
            allStock.StockList = TestList;
            Assert.AreEqual(allStock, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock aBook = new clsStock();
            aBook.ISBN = "0385603428";
            aBook.BookName = "Going Postal";
            aBook.Author = "Terry Pratchett";
            aBook.OnOrder = false;
            aBook.StockLevel = 100;
            aBook.Price = 9.99;
            aBook.SupplierID = 1;
            aBook.ReleaseDate = Convert.ToDateTime("25/9/2004");
            allStock.ThisStock = aBook;
            Assert.AreEqual(allStock.ThisStock, aBook);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock aBook = new clsStock();
            aBook.ISBN = "0385603428";
            aBook.BookName = "Going Postal";
            aBook.Author = "Terry Pratchett";
            aBook.OnOrder = false;
            aBook.StockLevel = 100;
            aBook.Price = 9.99;
            aBook.SupplierID = 1;
            aBook.ReleaseDate = Convert.ToDateTime("25/9/2004");
            TestList.Add(aBook);
            allStock.StockList = TestList;
            Assert.AreEqual(allStock.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOkay()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock aBook = new clsStock();
            string PrimaryKey = "";
            aBook.ISBN = "0385603428";
            aBook.BookName = "Going Postal";
            aBook.Author = "Terry Pratchett";
            aBook.OnOrder = false;
            aBook.StockLevel = 100;
            aBook.Price = 9.99;
            aBook.SupplierID = 1;
            aBook.ReleaseDate = Convert.ToDateTime("25/9/2004");
            allStock.ThisStock = aBook;
            PrimaryKey = allStock.Add();
            aBook.ISBN = PrimaryKey;
            allStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(allStock.ThisStock, aBook);
        }

    }
}
