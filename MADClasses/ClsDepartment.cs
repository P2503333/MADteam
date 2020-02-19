using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{
    public class clsDepartment
    { 
    //private data member for Department ID
        private Int32 mdep_ID;
    //private data member for Department Name
    private string mdep_Name;
    //private data member for Job Name
    private string mdep_Location;
    //private data member for number of Employees
    private Int32 mno_Employees;


    //public property for Department ID
    public int Dep_ID
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
    //public property for Department Name
    public string Dep_Name
    {
        get
        {
            return mdep_Name;
        }
        set
        {
            mdep_Name = value;
        }
    }
    //public property for Department Location
    public String Dep_Location
    {
        get
        {
            return mdep_Location;
        }
        set
        {
            mdep_Location = value;
        }
    }
    //public property for  Manager ID
    public Int32 No_Employees
    {
        get
        {
            return mno_Employees;
        }
        set
        {
            mno_Employees = value;
        }
    }


    public bool Find(int dep_ID)
    {
        //create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        //add the parameter for the Department to search for
        DB.AddParameter("@dep_ID", dep_ID);
        //execute the stored procedure
        DB.Execute("sproc_tblDepartment_FilterBydep_ID");
        //if one record is found (there should be either one or zero!)
        if (DB.Count == 1)
        {
            //copy the data from the database to the private data members (These need to be edited)
            mdep_ID = Convert.ToInt32(DB.DataTable.Rows[0]["dep_ID"]);
            mdep_Name = Convert.ToString(DB.DataTable.Rows[0]["dep_Name"]);
            mdep_Location = Convert.ToString(DB.DataTable.Rows[0]["dep_Location"]);
            mno_Employees = Convert.ToInt32(DB.DataTable.Rows[0]["no_Employees"]);
            //return that everything worked OK
            return true;
        }
        //if no record was found
        else
        {
            //return flse indicating a problem
            return false;
        }
    }

    public string Valid(int dep_ID, string dep_Name, string dep_Location, int no_Employees)
    {
        return "";
    }

    }
}