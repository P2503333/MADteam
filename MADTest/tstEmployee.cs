using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstEmployee
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //test to see if it exists
            Assert.IsNotNull(AnEmployee);
        }

        [TestMethod]
        public void Emp_ID_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.emp_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.emp_ID, TestData);
        }

        [TestMethod]
        public void Emp_Name_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            String TestData = "John Smith";

            //assigning data 

            AnEmployee.emp_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.emp_Name, TestData);
        }

        [TestMethod]
        public void job_Name_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            String TestData = "Test Maker";

            //assigning data 

            AnEmployee.job_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.job_Name, TestData);
        }

        [TestMethod]
        public void manager_ID_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.manager_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.manager_ID, TestData);
        }

        [TestMethod]
        public void hire_Date_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            DateTime TestData = DateTime.Now;

            //assigning data 

            AnEmployee.hire_Date = TestData;

            //test

            Assert.AreEqual(AnEmployee.hire_Date, TestData);
        }

        [TestMethod]
        public void salary_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            int TestData = 12000;

            //assigning data 

            AnEmployee.salary = TestData;

            //test

            Assert.AreEqual(AnEmployee.salary, TestData);
        }

        [TestMethod]
        public void dep_ID_PropertyOK()

        {

            //an instance of the class

            clsEmployee AnEmployee = new clsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.dep_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.dep_ID, TestData);
        }

    }
}
