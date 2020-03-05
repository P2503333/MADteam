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
        DateTime hire_Date = Convert.ToDateTime("15/01/2019");
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
            if (AnEmployee.Emp_Name != "Wilson Fisher")
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
            if (AnEmployee.Job_Name != "HR Support")
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
        public void TestActiveFound()
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
            if (AnEmployee.Active != true)
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
            DateTime hire_Date = DateTime.Now.Date;
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDExtremeMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = -1000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 0; //this should trigger an error
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 1; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 2; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 199; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 200; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 201; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeIDMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 100; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void EmployeeIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int emp_ID = 1000;
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = ""; //this should trigger an error
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "a"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "aa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeNameExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string emp_Name = "";
            emp_Name = emp_Name.PadRight(200, 'a'); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = ""; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "a"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobNameMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobNameExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            string job_Name = "";
            job_Name = job_Name.PadRight(200, 'a'); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ManagerIDExtremeMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = -1000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 0; //this should trigger an error
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 1; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 2; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 199; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 200; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 201; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 100; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ManagerIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int manager_ID = 1000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HireDateExtremeMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            DateTime hire_Date;
            String Error = "";
            //create some test data to pass to the method
            hire_Date = DateTime.Now.Date;
            hire_Date = hire_Date.AddYears(-100); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
               

    [TestMethod]
        public void HireDateMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime hire_Date;
            hire_Date = DateTime.Now.Date;
            hire_Date = hire_Date.AddDays(-1); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            DateTime hire_Date;
            String Error = "";
            //create some test data to pass to the method
            hire_Date = DateTime.Now.Date;
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            DateTime hire_Date;
            String Error = "";
            //create some test data to pass to the method
            hire_Date = DateTime.Now.Date;
            hire_Date = hire_Date.AddDays(1); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            DateTime hire_Date;
            String Error = "";
            //create some test data to pass to the method
            hire_Date = DateTime.Now.Date;
            hire_Date = hire_Date.AddYears(100); //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = -100000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 0; //this should trigger an error
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 1; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 2; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 199999; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 200000; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 200001; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 100000; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int salary = 4000000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDExtremeMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = -1000 ; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMinLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 0; //this should trigger an error
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 1; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 2; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 199; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 200; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 201; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMid()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 100; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            int dep_ID = 1000; //this should fail
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActiveMin()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            bool active = false; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActiveMax()
        {
            //create an instance of the class we want to create
            ClsEmployee AnEmployee = new ClsEmployee();
            //string variable to store any error message
            String Error = ""; DateTime hire_Date = DateTime.Now.Date;
            //create some test data to pass to the method
            bool active = true; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(emp_ID, emp_Name, job_Name, manager_ID, hire_Date, salary, dep_ID, active );
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
