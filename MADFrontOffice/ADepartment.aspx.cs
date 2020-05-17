using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class ADepartment : System.Web.UI.Page
{
    int dep_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        {
            

           dep_ID = Convert.ToInt32(Session["dep_ID"]);
            if (IsPostBack == false)
            {
                if (dep_ID != -1)
                {
                    DisplayDepartment();
                }
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsDepartment ADepartment = new clsDepartment();


        string dep_Location = txtdep_Location.Text;
        string dep_Name = txtdep_Name.Text;
        string no_Employees = txtno_Employee.Text;
        string Error = "";

        Error = ADepartment.Valid(dep_Name,dep_Location, no_Employees);
        if (Error == "")
        {
            ADepartment.Dep_ID = dep_ID;
            ADepartment.Dep_Name = dep_Name;
            ADepartment.Dep_Location = dep_Location;
            ADepartment.No_Employees = Convert.ToInt32(no_Employees);

            clsDepartmentCollection DepartmentList = new clsDepartmentCollection();

            if (Convert.ToInt32(dep_ID) == -1)
            {
                DepartmentList.ThisDepartment = ADepartment;
                DepartmentList.Add();
            }
            else
            {
                DepartmentList.ThisDepartment.Find(Convert.ToInt32(dep_ID));
                DepartmentList.ThisDepartment = ADepartment;
                DepartmentList.Update();
            }
            Response.Redirect("DefaultDepartment.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    void DisplayDepartment()
    {
        clsDepartmentCollection DepartmentList = new clsDepartmentCollection();

        DepartmentList.ThisDepartment.Find(dep_ID);
        //display the data

        txtdep_ID.Text = DepartmentList.ThisDepartment.Dep_ID.ToString();
        txtdep_Name.Text = DepartmentList.ThisDepartment.Dep_Name;
        txtdep_Location.Text = DepartmentList.ThisDepartment.Dep_Location;
        txtno_Employee.Text = DepartmentList.ThisDepartment.No_Employees.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("DefaultDepartment.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsDepartment ADepartment = new clsDepartment();
        Int32 dep_ID;
        Boolean Found = false;
        dep_ID = Convert.ToInt32(txtdep_ID.Text);
        Found = ADepartment.Find(dep_ID);

        if(Found == true)
        {
            txtdep_Location.Text = ADepartment.Dep_Location;
            txtdep_Name.Text = ADepartment.Dep_Name;
            txtno_Employee.Text = ADepartment.No_Employees.ToString();
        }
    }







}