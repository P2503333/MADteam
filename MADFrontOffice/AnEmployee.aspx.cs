using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class AnEmployee : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    int emp_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        ClsEmployee anEmployee = new ClsEmployee();

        anEmployee = (ClsEmployee)Session["anEmployee"];
        if (IsPostBack == false)
        {
            DisplayEmployee();

            if (emp_ID != -1)
            {
                DisplayEmployee();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (emp_ID == -1)
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

    void DisplayEmployee()
    {
        clsEmployeeCollection EmployeeList= new clsEmployeeCollection();

        EmployeeList.ThisEmployee.Find(emp_ID);
        //display the data

        txtemp_ID.Text = EmployeeList.ThisEmployee.Emp_ID.ToString();
        txtemp_Name.Text = EmployeeList.ThisEmployee.Emp_Name;
        txtjob_Name.Text = EmployeeList.ThisEmployee.Job_Name;
        txtmanager_ID.Text = EmployeeList.ThisEmployee.Manager_ID.ToString();
        txthire_Date.Text = EmployeeList.ThisEmployee.Hire_Date.ToString();
        txtsalary.Text = EmployeeList.ThisEmployee.Salary.ToString();
        txtdep_ID.Text = EmployeeList.ThisEmployee.Dep_ID.ToString();
        chkActive.Checked = EmployeeList.ThisEmployee.Active;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the address book
        clsEmployeeCollection EmployeeBook = new clsEmployeeCollection();
        //validate the data on the web form
        String Error = EmployeeBook.ThisEmployee.Valid(Convert.ToInt32(txtemp_ID.Text), txtemp_Name.Text, txtjob_Name.Text, Convert.ToInt32(txtmanager_ID.Text), Convert.ToDateTime(txthire_Date.Text), Convert.ToInt32(txtsalary.Text), Convert.ToInt32(txtdep_ID.Text), chkActive.Checked);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            EmployeeBook.ThisEmployee.Emp_ID = Convert.ToInt32(txtemp_ID.Text);
            EmployeeBook.ThisEmployee.Emp_Name = txtemp_Name.Text;
            EmployeeBook.ThisEmployee.Job_Name = txtjob_Name.Text;
            EmployeeBook.ThisEmployee.Manager_ID = Convert.ToInt32(txtmanager_ID.Text);
            EmployeeBook.ThisEmployee.Hire_Date = Convert.ToDateTime(txthire_Date.Text);
            EmployeeBook.ThisEmployee.Salary = Convert.ToInt32(txtsalary.Text);
            EmployeeBook.ThisEmployee.Dep_ID = Convert.ToInt32(txtdep_ID.Text);
            EmployeeBook.ThisEmployee.Active = chkActive.Checked;
            //add the record
            EmployeeBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
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
        clsEmployeeCollection EmployeeBook = new clsEmployeeCollection();
        //validate the data on the web form
        String Error = EmployeeBook.ThisEmployee.Valid(Convert.ToInt32(txtemp_ID.Text), txtemp_Name.Text, txtjob_Name.Text, Convert.ToInt32(txtmanager_ID.Text), Convert.ToDateTime(txthire_Date.Text), Convert.ToInt32(txtsalary.Text), Convert.ToInt32(txtdep_ID.Text), chkActive.Checked);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            EmployeeBook.ThisEmployee.Find(emp_ID);
            //get the data entered by the user
            EmployeeBook.ThisEmployee.Emp_ID = Convert.ToInt32(txtemp_ID.Text);
            EmployeeBook.ThisEmployee.Emp_Name = txtemp_Name.Text;
            EmployeeBook.ThisEmployee.Job_Name = txtjob_Name.Text;
            EmployeeBook.ThisEmployee.Manager_ID = Convert.ToInt32(txtmanager_ID.Text);
            EmployeeBook.ThisEmployee.Hire_Date = Convert.ToDateTime(txthire_Date.Text);
            EmployeeBook.ThisEmployee.Salary = Convert.ToInt32(txtsalary.Text);
            EmployeeBook.ThisEmployee.Dep_ID = Convert.ToInt32(txtdep_ID.Text);
            EmployeeBook.ThisEmployee.Active = chkActive.Checked; ;
            //update the record
            EmployeeBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
}