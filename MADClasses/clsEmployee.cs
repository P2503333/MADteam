﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{
    public class ClsEmployee
    {
        //private data member for Employee ID
        private Int32 memp_ID;
        //private data member for Employee Name
        private string memp_Name;
        //private data member for Job Name
        private string mjob_Name;
        //private data member for Manager ID
        private Int32 mmanager_ID;
        //private data member for Hire Date
        private DateTime mhire_Date;
        //private data member for Salary
        private int msalary;
        //private data member for Department ID
        private int mdep_ID;

        //public property for Employee ID
        public int emp_ID
        {
            get
            {
                return memp_ID;
            }
            set
            {
                memp_ID = value;
            }
        }
        //public property for Employee Name
        public string emp_Name
        {
            get
            {
                return memp_Name;
            }
            set
            {
                memp_Name = value;
            }
        }
        //public property for Job Name
        public String job_Name
        {
            get
            {
                return mjob_Name;
            }
            set
            {
                mjob_Name = value;
            }
        }
        //public property for  Manager ID
        public Int32 manager_ID
        {
            get
            {
                return mmanager_ID;
            }
            set
            {
                mmanager_ID = value;
            }
        }
        //public property for Hire Date
        public DateTime hire_Date
        {
            get
            {
                return mhire_Date;
            }
            set
            {
                mhire_Date = value;
            }
        }
        //public property for Salary
        public int salary
        {
            get
            {
                return msalary;
            }
            set
            {
                msalary = value;
            }
        }
        //public property for Department ID
        public int dep_ID
        {
            get
            {
                return mdep_ID;
            }
            set
            {
                mdep_ID = value;
            }
        }

        public bool Find(int emp_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the employee to search for
            DB.AddParameter("@emp_ID", emp_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblEmployee_FilterByemp_ID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members (These need to be edited)
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
                memp_ID = Convert.ToInt32(DB.DataTable.Rows[0]["emp_ID"]);
            }
        }

    }
}
