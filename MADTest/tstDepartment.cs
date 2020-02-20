using System;
using MADClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MADTest
{
    [TestClass]
    public class tstDepartment
    {

        //good test data
        //TEST DATA
        int Dep_ID = 1;
        string Dep_Name = "Human Resources";
        string Dep_Location = "London";
        int No_Employees = 11;


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsDepartment AnDepartment = new clsDepartment();
            //test to see if it exists
            Assert.IsNotNull(AnDepartment);
        }

        [TestMethod]
        public void Dep_ID_PropertyOK()

        {

            //an instance of the class

            clsDepartment AnDepartment = new clsDepartment();

            //test data

            int TestData = 1;

            //assigning data 

            AnDepartment.Dep_ID = TestData;

            //test

            Assert.AreEqual(AnDepartment.Dep_ID, TestData);
        }

        [TestMethod]
        public void Dep_Name_PropertyOK()

        {

            //an instance of the class

            clsDepartment AnDepartment = new clsDepartment();

            //test data

            String TestData = "John Smith";

            //assigning data 

            AnDepartment.Dep_Name = TestData;

            //test

            Assert.AreEqual(AnDepartment.Dep_Name, TestData);
        }

        [TestMethod]
        public void Dep_Location_PropertyOK()

        {

            //an instance of the class

            clsDepartment AnDepartment = new clsDepartment();

            //test data

            String TestData = "Test Maker";

            //assigning data 

            AnDepartment.Dep_Location = TestData;

            //test

            Assert.AreEqual(AnDepartment.Dep_Location, TestData);
        }

        [TestMethod]
        public void No_Employees_PropertyOK()

        {

            //an instance of the class

            clsDepartment AnDepartment = new clsDepartment();

            //test data

            int TestData = 100;

            //assigning data 

            AnDepartment.No_Employees = TestData;

            //test

            Assert.AreEqual(AnDepartment.No_Employees, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance
            clsDepartment AnDepartment = new clsDepartment();
            //boolean variable to store the result
            Boolean Found = false;
            //test data
            int Dep_ID = 1;
            //invoke the method
            Found = AnDepartment.Find(Dep_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDepartmentIDFound()
        {
            //create an instance
            clsDepartment AnDepartment = new clsDepartment();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int Dep_ID = 1;
            //invoke the method
            Found = AnDepartment.Find(Dep_ID);
            //check the Department ID
            if (AnDepartment.Dep_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentNameFound()
        {
            //create an instance
            clsDepartment AnDepartment = new clsDepartment();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int Dep_ID = 1;
            //invoke the method
            Found = AnDepartment.Find(Dep_ID);
            //check the Department ID
            if (AnDepartment.Dep_Name != "Human Resources")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentLocationFound()
        {
            //create an instance
            clsDepartment AnDepartment = new clsDepartment();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int Dep_ID = 1;
            //invoke the method
            Found = AnDepartment.Find(Dep_ID);
            //check the Department ID
            if (AnDepartment.Dep_Location != "London")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNoEmployeesFound()
        {
            //create an instance
            clsDepartment AnDepartment = new clsDepartment();
            //bool variable to store the result of the search
            Boolean Found = false;
            //bool variable to record if the data is OK
            Boolean OK = true;
            //test data
            int Dep_ID = 1;
            //invoke the method
            Found = AnDepartment.Find(Dep_ID);
            //check the Department ID
            if (AnDepartment.No_Employees != 11)
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
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}