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
            clsDepartment aDepartment = new clsDepartment();

            aDepartment = (clsDepartment)Session["aDepartment"];
            if (IsPostBack == false)
            {
                DisplayDepartment();

                if (dep_ID != -1)
                {
                    DisplayDepartment();
                }
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (dep_ID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
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

    void Add()
    {
        //create an instance of the address book
        clsDepartmentCollection DepartmentBook = new clsDepartmentCollection();
        //validate the data on the web form
        String Error = DepartmentBook.ThisDepartment.Valid(Convert.ToInt32(txtdep_ID.Text), txtdep_Name.Text, txtdep_Location.Text, Convert.ToInt32(txtno_Employee.Text));
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            DepartmentBook.ThisDepartment.Dep_ID = Convert.ToInt32(txtdep_ID.Text);
            DepartmentBook.ThisDepartment.Dep_Name = txtdep_Name.Text;
            DepartmentBook.ThisDepartment.Dep_Location = txtdep_Location.Text;
            DepartmentBook.ThisDepartment.No_Employees = Convert.ToInt32(txtno_Employee.Text);
            //add the record
            DepartmentBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("DefaultDepartment.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void Update()
    {
        //create an instance of the address book
        clsDepartmentCollection DepartmentBook = new clsDepartmentCollection();
        //validate the data on the web form
        String Error = DepartmentBook.ThisDepartment.Valid(Convert.ToInt32(txtdep_ID.Text), txtdep_Name.Text, txtdep_Location.Text, Convert.ToInt32(txtno_Employee.Text));
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            DepartmentBook.ThisDepartment.Find(dep_ID);
            //get the data entered by the user
            DepartmentBook.ThisDepartment.Dep_ID = Convert.ToInt32(txtdep_ID.Text);
            DepartmentBook.ThisDepartment.Dep_Name = txtdep_Name.Text;
            DepartmentBook.ThisDepartment.Dep_Location = txtdep_Location.Text;
            DepartmentBook.ThisDepartment.No_Employees = Convert.ToInt32(txtno_Employee.Text);

            //update the record
            DepartmentBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("DefaultDepartment.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }





}