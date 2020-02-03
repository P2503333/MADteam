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
    }
}
