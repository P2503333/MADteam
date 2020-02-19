using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class TstEmployee
    {

        //good test data
        //TEST DATA
        int emp_ID = 21; 
        string emp_Name = "Wilson Fisher";
        string job_Name = "HR Support";
        int manager_ID = 1;
        string hire_Date = DateTime.Now.Date.ToString();
        int salary = 15000;
        int dep_ID = 1;
        bool active = true;


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

            AnEmployee.Emp_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.Emp_ID, TestData);
        }

        [TestMethod]
        public void Emp_Name_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            String TestData = "John Smith";

            //assigning data 

            AnEmployee.Emp_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.Emp_Name, TestData);
        }

        [TestMethod]
        public void Job_Name_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            String TestData = "Test Maker";

            //assigning data 

            AnEmployee.Job_Name = TestData;

            //test

            Assert.AreEqual(AnEmployee.Job_Name, TestData);
        }

        [TestMethod]
        public void Manager_ID_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.Manager_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.Manager_ID, TestData);
        }

        [TestMethod]
        public void Hire_Date_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            DateTime TestData = DateTime.Now;

            //assigning data 

            AnEmployee.Hire_Date = TestData;

            //test

            Assert.AreEqual(AnEmployee.Hire_Date, TestData);
        }

        [TestMethod]
        public void Salary_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 12000;

            //assigning data 

            AnEmployee.Salary = TestData;

            //test

            Assert.AreEqual(AnEmployee.Salary, TestData);
        }

        [TestMethod]
        public void Dep_ID_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            int TestData = 100;

            //assigning data 

            AnEmployee.Dep_ID = TestData;

            //test

            Assert.AreEqual(AnEmployee.Dep_ID, TestData);
        }

        [TestMethod]
        public void Active_PropertyOK()

        {

            //an instance of the class

            ClsEmployee AnEmployee = new ClsEmployee();

            //test data

            bool TestData = true;

            //assigning data 

            AnEmployee.Active = TestData;

            //test

            Assert.AreEqual(AnEmployee.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //boolean variable to store the result
            Boolean Found = false;
            //test data
            int emp_ID = 38;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeIDFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.Emp_ID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmployeeNameFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.Emp_Name != "Wilson Fischer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobNameFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.Emp_Name != "HP Support")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerIDFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.Manager_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            DateTime DateTemp = Convert.ToDateTime(hire_Date);
            //check the employee ID
            if (AnEmployee.Hire_Date != DateTemp)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
           if (AnEmployee.Salary != 15000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentIDFound()
        {
            //create an instance
            ClsEmployee AnEmployee = new ClsEmployee();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int emp_ID = 21;
            //invoke the method
            Found = AnEmployee.Find(emp_ID);
            //check the employee ID
            if (AnEmployee.Dep_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

       
    }
}
