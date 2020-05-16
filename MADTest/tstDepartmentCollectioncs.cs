using System;
using System.Collections.Generic;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MADTest
{
    [TestClass]
    public class tstDepartmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creat a instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDepartments);
        }

        [TestMethod]
        public void DepartmentListOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsDepartment> TestList = new List<clsDepartment>();
            //add an item to the list
            //create the item of test data
            clsDepartment TestDepartment = new clsDepartment();
            //set its properties
            TestDepartment.Dep_ID =5;
            TestDepartment.Dep_Name = "Media";
            TestDepartment.Dep_Location = "Poole";
            TestDepartment.No_Employees = 22;
            //add the item to the test list
            TestList.Add(TestDepartment);
            //assign the data to the property
            AllDepartments.DepartmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDepartments.DepartmentList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 117;
            //assign the data to the property
            AllDepartments.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllDepartments.Count, SomeCount);
        }

        [TestMethod]
        public void ThisDepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create some test data to assign to the property
            clsDepartment TestDepartment = new clsDepartment();
            //set the properties of the test object
            TestDepartment.Dep_ID = 6;
            TestDepartment.Dep_Name = "Media";
            TestDepartment.Dep_Location = "Suffolk";
            TestDepartment.No_Employees = 23;
            //assign the data to the property
            AllDepartments.ThisDepartment = TestDepartment;
            //test to see that the two values are the same
            Assert.AreEqual(AllDepartments.ThisDepartment,TestDepartment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsDepartment> TestList = new List<clsDepartment>();
            //add an item to the list
            //create the item of test data
            clsDepartment TestDepartment = new clsDepartment();
            //set its properties
            TestDepartment.Dep_ID = 7;
            TestDepartment.Dep_Name = "Store";
            TestDepartment.Dep_Location = "Liverpool";
            TestDepartment.No_Employees = 44;
            //add the item to the test list
            TestList.Add(TestDepartment);
            //assign the data to the property
            AllDepartments.DepartmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDepartments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection(); ;
            //create the item of test data
            clsDepartment TestDepartment = new clsDepartment();
            //var to store the primary key
            Int32 PrimaryKey = 8;
            //set its properties
            TestDepartment.Dep_ID = 8;
            TestDepartment.Dep_Name = "Store";
            TestDepartment.Dep_Location = "Liverpool";
            TestDepartment.No_Employees = 44;
            //set ThisEmployee to the test data
            AllDepartments.ThisDepartment = TestDepartment;
            //add the record
            AllDepartments.Add();
            //set the primary key of the test data
            //find the record
            AllDepartments.ThisDepartment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDepartments.ThisDepartment, TestDepartment);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create the item of test data
            clsDepartment TestDepartment = new clsDepartment();
            //var to store the primary key
            Int32 PrimaryKey = 9;
            //set its properties
            TestDepartment.Dep_ID = 9;
            TestDepartment.Dep_Name = "Store";
            TestDepartment.Dep_Location = "Liverpool";
            TestDepartment.No_Employees = 44;
            //set ThisAddress to the test data
            AllDepartments.ThisDepartment = TestDepartment;
            //add the record
            PrimaryKey = AllDepartments.Add();
            //set the primary key of the test data
            TestDepartment.Dep_ID = PrimaryKey;
            //find the record
            AllDepartments.ThisDepartment.Find(PrimaryKey);
            //delete the record
            AllDepartments.Delete();
            //now find the record   
            Boolean Found = AllDepartments.ThisDepartment.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create the item of test data
            clsDepartment TestDepartment = new clsDepartment();
            //var to store the primary key
            Int32 PrimaryKey = 10;
            //set its properties
            TestDepartment.Dep_ID = 10;
            TestDepartment.Dep_Name = "Store";
            TestDepartment.Dep_Location = "Liverpool";
            TestDepartment.No_Employees = 44;
            //set ThisAddress to the test data
            AllDepartments.ThisDepartment = TestDepartment;
            //add the record
            PrimaryKey = AllDepartments.Add();
            //set the primary key of the test data
            TestDepartment.Dep_ID = PrimaryKey;
            //modify the test data
            TestDepartment.Dep_ID = 10;
            TestDepartment.Dep_Name = "Stores";
            TestDepartment.Dep_Location = "Liverpool";
            TestDepartment.No_Employees = 44;
            //set the record based on the new test data
            AllDepartments.ThisDepartment = TestDepartment;
            //update the record
            AllDepartments.Update();
            //find the record
            AllDepartments.ThisDepartment.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllDepartments.ThisDepartment, TestDepartment);
        }

        [TestMethod]
        public void ReportByDepartmentNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsDepartmentCollection AllDepartments = new clsDepartmentCollection();
            //create an instance of the filtered data
            clsDepartmentCollection FilteredDepartment = new clsDepartmentCollection();
            //apply a blank string (should return all records);
            FilteredDepartment.ReportByDepartmentLocation("");
            //test to see that the two values are the same
            Assert.AreEqual(FilteredDepartment.Count, AllDepartments.Count);
        }

        [TestMethod]
        public void ReportByDepartmentNameNoneFound()
        {
            //create an instance of the filtered data
            clsDepartmentCollection FilteredDepartment = new clsDepartmentCollection();
            //apply a post code that doesn't exist
            string test = "snggfs";
            FilteredDepartment.ReportByDepartmentLocation(test);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredDepartment.Count);
        }

        [TestMethod]
        public void ReportByDepartmentNameTestDataFound()
        {
            //create an instance of the filtered data
            clsDepartmentCollection FilteredDepartment = new clsDepartmentCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Name that doesn't exist
            FilteredDepartment.ReportByDepartmentLocation("Newcastle");
            //check that the correct number of records are found
            if (FilteredDepartment.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredDepartment.DepartmentList[0].Dep_ID != 6)
                {
                    OK = false;
                }
                //check that the first record is ID 67
                if (FilteredDepartment.DepartmentList[1].Dep_ID != 10)
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
