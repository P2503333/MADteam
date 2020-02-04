using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class TstEmployee
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            ClsEmployee AnEmployee = new ClsEmployee();
            //test to see if it exists
            Assert.IsNotNull(AnEmployee);
        }

        [TestMethod]
        public void Emp_ID_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

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

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            String TestData = "John Smith";

            //assigning data 

            AnEmployee.emp_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.emp_Name, TestData);
        }

        [TestMethod]
        public void Job_Name_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            String TestData = "Test Maker";

            //assigning data 

            AnEmployee.job_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.job_Name, TestData);
        }

        [TestMethod]
        public void Manager_ID_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.manager_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.manager_ID, TestData);
        }

        [TestMethod]
        public void Hire_Date_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            DateTime TestData = DateTime.Now;

            //assigning data 

            AnEmployee.hire_Date = TestData;

            //test

            Assert.AreEqual(AnEmployee.hire_Date, TestData);
        }

        [TestMethod]
        public void Salary_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 12000;

            //assigning data 

            AnEmployee.salary = TestData;

            //test

            Assert.AreEqual(AnEmployee.salary, TestData);
        }

        [TestMethod]
        public void Dep_ID_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.dep_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.dep_ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //boolean variable to store the result
            Boolean Found = false;
            //test data
            Int32 emp_ID = 38;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeNoFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            Int32 emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.emp_ID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
