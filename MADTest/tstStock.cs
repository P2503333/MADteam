using System;
using System.Collections.Generic;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class TstStock
    {
        //Valid test data
        string ISBN = "1234567891234";
        String Price = "9.99";
        //String OnOrder = "True";
        String StockLevel = "99";
        String SupplierId = "1";
        String Author = "Terry Pratchett";
        String BookName = "Going Postal";
        String ReleaseDate = "1/1/2020";




        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of stock table
            clsStock stock = new clsStock();
            //check it's not null
            Assert.IsNotNull(stock);
        }
        [TestMethod]
        public void ISBNOK()
        {
            clsStock stock = new clsStock();
            //test data
            string Test = "1234567891234";
            //assign to isbn property
            stock.ISBN = Test;
            //check they match
            Assert.AreEqual(stock.ISBN, Test);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsStock stock = new clsStock();
            //test data
            double Test = 9.99;
            //assign to isbn property
            stock.Price = Test;
            //check they match
            Assert.AreEqual(stock.Price, Test);
        }
        [TestMethod]
        public void StockLevelOK()
        {
            clsStock stock = new clsStock();
            //test data
            int Test = 9;
            //assign to isbn property
            stock.StockLevel = Test;
            //check they match
            Assert.AreEqual(stock.StockLevel, Test);
        }
        [TestMethod]
        public void SupplierIDOK()
        {
            clsStock stock = new clsStock();
            //test data
            int Test = 1;
            //assign to isbn property
            stock.SupplierID = Test;
            //check they match
            Assert.AreEqual(stock.SupplierID, Test);
        }
        [TestMethod]
        public void AuthorOK()
        {
            clsStock stock = new clsStock();
            //test data
            string Test = "Terry Pratchett";
            //assign to isbn property
            stock.Author = Test;
            //check they match
            Assert.AreEqual(stock.Author, Test);
        }
        [TestMethod]
        public void BookNameOK()
        {
            clsStock stock = new clsStock();
            //test data
            string Test = "Going Postal";
            //assign to isbn property
            stock.BookName = Test;
            //check they match
            Assert.AreEqual(stock.BookName, Test);
        }
        [TestMethod]
        public void OnOrderOK()
        {
            clsStock stock = new clsStock();
            //test data
            Boolean Test = true;
            //assign to isbn property
            stock.OnOrder = Test;
            //check they match
            Assert.AreEqual(stock.OnOrder, Test);
        }
        [TestMethod]
        public void ReleaseDateOK()
        {
            clsStock stock = new clsStock();
            //test data
            DateTime Test = Convert.ToDateTime("1/1/2020");
            //assign to isbn property
            stock.ReleaseDate = Test;
            //check they match
            Assert.AreEqual(stock.ReleaseDate, Test);
        }
        [TestMethod]
        public void TestFind()
        { //create a stock class instance
            clsStock stock = new clsStock();
            //variable to store result
            Boolean Found = false;
            string ISBN = "1111111111111";
            //invoke the method
            Found = stock.Find(ISBN);
            //test the result
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestISBNfound()
        {//create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the isbn

            if (stock.ISBN != "1111111111111")
            {
                OK = false;
            }
            Assert.IsTrue(OK);



        }
        [TestMethod]
        public void TestPricefound()
        {//create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the price
            if (stock.Price != 5.9900)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierIDfound()
        {//create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the supplier ID
            if (stock.SupplierID != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStockLevelFound()
        {
            //create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the Stock Level
            if (stock.StockLevel != 50)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBookNameFound()
        {
            //create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the book name
            if (stock.BookName != "Guards! Guards!")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the date
            if (stock.ReleaseDate != Convert.ToDateTime("28/01/1980"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOnOrderFound()
        {//create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check if it's on order
            if (stock.OnOrder != false)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAuthorFound()
        {//create a class instance
            clsStock stock = new clsStock();
            //variable to store search result
            Boolean Found = false;
            //variable to record if the data is valid
            Boolean OK = true;
            //test data to use
            string isbn = "1111111111111";
            //invoke the method
            Found = stock.Find(isbn);
            //check the Author
            if (stock.Author != "Terry Pratchett")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock stock = new clsStock();
            //variable for error message
            String Error = "";
            //Run the method
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
        }
        [TestMethod]
        public void ISBNExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(9, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(10, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(11, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(12, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(13, '9');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ISBNMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(14, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(500, '2');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ISBNNumbers()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String ISBN = "";
            ISBN = ISBN.PadRight(13, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String SupplierId = "-1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMinMinus1()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "0";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMinPlus1()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "2";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxMinus1()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "999";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "1000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "1001";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "500";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "10000000000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDWrongType()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string SupplierId = "Steve";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "-999";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "-1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "0";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "999";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "1000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "1001";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "500";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "1000000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLevelWrongType()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string StockLevel = "Steve";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "a";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "ab";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            BookName = BookName.PadRight(199, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            BookName = BookName.PadRight(200, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            BookName = BookName.PadRight(201, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            BookName = BookName.PadRight(100, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "";
            BookName = BookName.PadRight(800, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameWrongType()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string BookName = "True";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "-1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "0";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "0.01";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "0.02";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "999999.99";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "999999.99";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "10000000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "500000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "10000000000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceWrongType()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Price = "Steve";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateFourDigitYear()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/1";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/0001";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "31/12/1439";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/1440";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "2/1/1440";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "30/12/2099";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "31/12/2099";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/2100";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/1880";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "1/1/3000";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ReleaseDateWrongType()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string ReleaseDate = "steve";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
   
        [TestMethod]
        public void AuthorMinMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "a";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "aa";
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMaxMinusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Author = Author.PadRight(99, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Author = Author.PadRight(100, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Author = Author.PadRight(101, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Author = Author.PadRight(50, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            String Author = "";
            Author = Author.PadRight(1000, 'a');
            Error = stock.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierId, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }
        

    }
    

}
