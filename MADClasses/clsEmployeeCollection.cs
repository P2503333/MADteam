using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{
    public class clsEmployeeCollection
    {

        //private data member for the list
        List<ClsEmployee> mEmployeeList = new List<ClsEmployee>();
        //private data member thisEmployee
        ClsEmployee mAnEmployee = new ClsEmployee();

        //constructer for the class
        public clsEmployeeCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblEmployee_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the Employee list
        public List<ClsEmployee> EmployeeList
        {
            get
            {
                //return the private data
                return mEmployeeList;
            }
            set
            {
                //set the private data
                mEmployeeList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mEmployeeList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisEmployee
        public ClsEmployee ThisEmployee
        {
            get
            {
                //return the private data
                return mAnEmployee;
            }
            set
            {
                //set the private data
                mAnEmployee = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mEmployeeList = new List<ClsEmployee>();
            //while there are records to process
            while (index < RecordCount)
            {
                //create a blank employee
                ClsEmployee anEmployee = new ClsEmployee();
                //read in the fields from the current record
                anEmployee.Emp_ID = Convert.ToInt32(DB.DataTable.Rows[index]["emp_ID"]);
                anEmployee.Emp_Name = Convert.ToString(DB.DataTable.Rows[index]["emp_Name"]);
                anEmployee.Job_Name = Convert.ToString(DB.DataTable.Rows[index]["job_Name"]);
                anEmployee.Manager_ID = Convert.ToInt32(DB.DataTable.Rows[index]["manager_ID"]);
                anEmployee.Hire_Date = Convert.ToDateTime(DB.DataTable.Rows[index]["hire_Date"]);
                anEmployee.Salary = Convert.ToInt32(DB.DataTable.Rows[index]["salary"]);
                anEmployee.Dep_ID = Convert.ToInt32(DB.DataTable.Rows[index]["dep_ID"]);
                anEmployee.Active = Convert.ToBoolean(DB.DataTable.Rows[index]["active"]);
                //add the record to the private data member
                mEmployeeList.Add(anEmployee);
                //point at the next record
                index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisEmployee
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@emp_ID", mAnEmployee.Emp_ID);
            DB.AddParameter("@emp_Name", mAnEmployee.Emp_Name);
            DB.AddParameter("@job_Name", mAnEmployee.Job_Name);
            DB.AddParameter("@manager_ID", mAnEmployee.Manager_ID);
            DB.AddParameter("@hire_Date", mAnEmployee.Hire_Date);
            DB.AddParameter("@salary", mAnEmployee.Salary);
            DB.AddParameter("@dep_ID", mAnEmployee.Dep_ID);
            DB.AddParameter("@active", mAnEmployee.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblEmployee_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by AnEmployee
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("emp_ID", mAnEmployee.Emp_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblEmployee_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of AnEmployee
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@emp_ID", mAnEmployee.Emp_ID);
            DB.AddParameter("@emp_Name", mAnEmployee.Emp_Name);
            DB.AddParameter("@job_Name", mAnEmployee.Job_Name);
            DB.AddParameter("@manager_ID", mAnEmployee.Manager_ID);
            DB.AddParameter("@hire_Date", mAnEmployee.Hire_Date);
            DB.AddParameter("@salary", mAnEmployee.Salary);
            DB.AddParameter("@dep_ID", mAnEmployee.Dep_ID);
            DB.AddParameter("@active", mAnEmployee.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblEmployee_Update");
        }

        public void ReportByEmployeeName(string emp_Name)
        {
            //filters the records based on a Department ID
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Department ID parameter to the database
            DB.AddParameter("@emp_Name", mAnEmployee.Emp_Name);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByemp_Name");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
