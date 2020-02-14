using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of stock table
            clsStock stock = new clsStock();
            //check it's not null
            Assert.IsNotNull(stock);
        }
        [TestMethod]
        public void TestFind()
        { //create a stock class instance
            clsStock stock = new clsStock();
            //variable to store result
            Boolean Found = false;
            //make something to look for
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the isbn

            if (stock.ISBN != "1234567891234")
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the price
            if (stock.Price != 9.99) 
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the supplier ID
            if (stock.SupplierID != 1)
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the Stock Level
            if (stock.StockLevel != 100)
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the book name
            if (stock.BookName != "Great Expectations")
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the date
            if (stock.ReleaseDate != Convert.ToDateTime("1/1/1990"))
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check if it's on order
            if (stock.OnOrder != true)
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
            string isbn = "1234567891234";
            //invoke the method
            Found = stock.Find(isbn);
            //check the Author
            if (stock.Author != "Charles Dickens")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }
    }
}

