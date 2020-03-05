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

        [TestMethod]
        public void DepartmentIDExtremeMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = -1000; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 0; //this should trigger an error
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 1; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 2; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 199; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 200; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 201; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDMid()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 100; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int Dep_ID = 1000; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentNameMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = ""; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "a"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameMid()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Name = "";
            Dep_Name = Dep_Name.PadRight(200, 'a'); //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = ""; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "a"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationMid()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentLocationExtremeMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            string Dep_Location = "";
            Dep_Location = Dep_Location.PadRight(200, 'a'); //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesExtremeMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = -1000; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMinLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 0; //this should trigger an error
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMin()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 1; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 2; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 199; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 200; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";
             
            //create some test data to pass to the method
            int No_Employees = 201; //this should fail
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesMid()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int No_Employees = 100; //this should be ok
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberOfEmployeesExtremeMax()
        {
            //create an instance of the class we want to create
            clsDepartment AnDepartment = new clsDepartment();
            //string variable to store any error message
            String Error = "";  
            //create some test data to pass to the method
            int No_Employees = 1000;
            //invoke the method
            Error = AnDepartment.Valid(Dep_ID, Dep_Name, Dep_Location, No_Employees);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}