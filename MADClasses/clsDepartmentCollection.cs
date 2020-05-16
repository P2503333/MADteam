using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{

    public class clsDepartmentCollection
    {

        //private data member for the list
        List<clsDepartment> mDepartmentList = new List<clsDepartment>();
        //private data member thisDepartment
        clsDepartment mADepartment = new clsDepartment();

        //constructer for the class
        public clsDepartmentCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDepartment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the Department list
        public List<clsDepartment> DepartmentList
        {
            get
            {
                //return the private data
                return mDepartmentList;
            }
            set
            {
                //set the private data
                mDepartmentList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mDepartmentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisEmployee
        public clsDepartment ThisDepartment
        {
            get
            {
                //return the private data
                return mADepartment;
            }
            set
            {
                //set the private data
                mADepartment = value;
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
            mDepartmentList = new List<clsDepartment>();
            //while there are records to process
            while (index < RecordCount)
            {
                //create a blank employee
                clsDepartment aDepartment = new clsDepartment();
                //read in the fields from the current record
                aDepartment.Dep_ID = Convert.ToInt32(DB.DataTable.Rows[index]["dep_ID"]);
                aDepartment.Dep_Name = Convert.ToString(DB.DataTable.Rows[index]["dep_Name"]);
                aDepartment.Dep_Location = Convert.ToString(DB.DataTable.Rows[index]["dep_Location"]);
                aDepartment.No_Employees = Convert.ToInt32(DB.DataTable.Rows[index]["no_Employees"]);
                //add the record to the private data member
                mDepartmentList.Add(aDepartment);
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
            DB.AddParameter("@dep_ID", mADepartment.Dep_ID);
            DB.AddParameter("@dep_Name", mADepartment.Dep_Name);
            DB.AddParameter("@dep_Location", mADepartment.Dep_Location);
            DB.AddParameter("@no_Employees", mADepartment.No_Employees);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDepartment_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by AnEmployee
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("dep_ID", mADepartment.Dep_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblDepartment_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ADepartment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@dep_ID", mADepartment.Dep_ID);
            DB.AddParameter("@dep_Name", mADepartment.Dep_Name);
            DB.AddParameter("@dep_Location", mADepartment.Dep_Location);
            DB.AddParameter("@no_Employees", mADepartment.No_Employees);
            //execute the stored procedure
            DB.Execute("sproc_tblDepartment_Update");
        }

        public void ReportByDepartmentLocation(string dep_Location)
        {
            //filters the records based on an Employee Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Employee Name parameter to the database
            DB.AddParameter("@dep_Location", dep_Location);
            //execute the stored procedure
            DB.Execute("sproc_tblDepartment_FilterBydep_Location");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}

