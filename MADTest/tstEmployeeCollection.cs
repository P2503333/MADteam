using System;
using System.Collections.Generic;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstEmployeeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creat a instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //test to see that it exists
            Assert.IsNotNull(AllEmployees);
        }

        [TestMethod]
        public void EmployeeListOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsEmployee> TestList = new List<ClsEmployee>();
            //add an item to the list
            //create the item of test data
            ClsEmployee TestEmployee = new ClsEmployee();
            //set its properties
            TestEmployee.Emp_ID = 113;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //add the item to the test list
            TestList.Add(TestEmployee);
            //assign the data to the property
            AllEmployees.EmployeeList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployees.EmployeeList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 117;
            //assign the data to the property
            AllEmployee.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployee.Count, SomeCount);
        }

        [TestMethod]
        public void ThisEmployeePropertyOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            //create some test data to assign to the property
            ClsEmployee TestEmployee = new ClsEmployee();
            //set the properties of the test object
            TestEmployee.Emp_ID = 113;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //assign the data to the property
            AllEmployee.ThisEmployee = TestEmployee;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployee.ThisEmployee, TestEmployee);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClsEmployee> TestList = new List<ClsEmployee>();
            //add an item to the list
            //create the item of test data
            ClsEmployee TestEmployee = new ClsEmployee();
            //set its properties
            TestEmployee.Emp_ID = 113;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //add the item to the test list
            TestList.Add(TestEmployee);
            //assign the data to the property
            AllEmployee.EmployeeList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployee.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            //create the item of test data
            ClsEmployee TestEmployee = new ClsEmployee();
            //var to store the primary key
            Int32 PrimaryKey = 115;
            //set its properties
            TestEmployee.Emp_ID = PrimaryKey;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //set ThisEmployee to the test data
            AllEmployee.ThisEmployee = TestEmployee;
            //add the record
            AllEmployee.Add();
            //set the primary key of the test data
            //find the record
            AllEmployee.ThisEmployee.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployee.ThisEmployee, TestEmployee);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create the item of test data
            ClsEmployee TestEmployee = new ClsEmployee();
            //var to store the primary key
            Int32 PrimaryKey = 116;
            //set its properties
            TestEmployee.Emp_ID = 116;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //set ThisAddress to the test data
            AllEmployees.ThisEmployee = TestEmployee;
            //add the record
            PrimaryKey = AllEmployees.Add();
            //set the primary key of the test data
            TestEmployee.Emp_ID = PrimaryKey;
            //find the record
            AllEmployees.ThisEmployee.Find(PrimaryKey);
            //delete the record
            AllEmployees.Delete();
            //now find the record   
            Boolean Found = AllEmployees.ThisEmployee.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create the item of test data
            ClsEmployee TestEmployee = new ClsEmployee();
            //var to store the primary key
            Int32 PrimaryKey = 113;
            //set its properties
            TestEmployee.Emp_ID = 113;
            TestEmployee.Emp_Name = "Jake Wills";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //set ThisAddress to the test data
            AllEmployees.ThisEmployee = TestEmployee;
            //add the record
            PrimaryKey = AllEmployees.Add();
            //set the primary key of the test data
            TestEmployee.Emp_ID = PrimaryKey;
            //modify the test data
            TestEmployee.Emp_ID = 113;
            TestEmployee.Emp_Name = "Jake Williams";
            TestEmployee.Job_Name = "Supporter";
            TestEmployee.Manager_ID = 2;
            TestEmployee.Hire_Date = DateTime.Now.Date;
            TestEmployee.Salary = 22000;
            TestEmployee.Dep_ID = 3;
            TestEmployee.Active = true;
            //set the record based on the new test data
            AllEmployees.ThisEmployee = TestEmployee;
            //update the record
            AllEmployees.Update();
            //find the record
            AllEmployees.ThisEmployee.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllEmployees.ThisEmployee, TestEmployee);
        }

        [TestMethod]
        public void ReportByEmployeeNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsEmployeeCollection AllEmpoyees = new clsEmployeeCollection();
            //create an instance of the filtered data
            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
            //apply a blank string (should return all records);
            FilteredEmployees.ReportByEmployeeName("");
            //test to see that the two values are the same
            Assert.AreEqual(FilteredEmployees.Count, AllEmpoyees.Count);
        }

        [TestMethod]
        public void ReportByEmployeeNameNoneFound()
        {
            //create an instance of the filtered data
            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
            //apply a post code that doesn't exist
            string test = "";
            FilteredEmployees.ReportByEmployeeName(test);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredEmployees.Count);
        }

        [TestMethod]
        public void ReportByEmployeeNameTestDataFound()
        {
            //create an instance of the filtered data
            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Name that doesn't exist
            FilteredEmployees.ReportByEmployeeName("Thomas Wilson");
            //check that the correct number of records are found
            if (FilteredEmployees.Count == 3)
            {
                //check that the first record is ID 1
                if (FilteredEmployees.EmployeeList[0].Emp_ID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 67
                if (FilteredEmployees.EmployeeList[1].Emp_ID != 67)
                {
                    OK = false;
                }
                //check that the first record is ID 106
                if (FilteredEmployees.EmployeeList[2].Emp_ID != 106)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
