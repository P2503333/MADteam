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

        emp_ID = Convert.ToInt32(Session["emp_ID"]);
        if (IsPostBack == false)
        {

            if (emp_ID != -1)
            {
                DisplayEmployee();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsEmployee AnEmployee = new ClsEmployee();


        string emp_Name = txtemp_Name.Text;
        string job_Name = txtjob_Name.Text;
        string dep_ID = txtdep_ID.Text;
        string hire_Date = txthire_Date.Text;
        string manager_ID = txtmanager_ID.Text;
        string salary = txtsalary.Text;
        string check = chkActive.Text;
        string Error = "";

        Error = AnEmployee.Valid(emp_Name, job_Name, manager_ID, Convert.ToDateTime(hire_Date), salary, dep_ID, chkActive.Checked);
        if (Error == "")
        {
            AnEmployee.Emp_ID = emp_ID;
            AnEmployee.Emp_Name = emp_Name;
            AnEmployee.Job_Name = job_Name;
            AnEmployee.Manager_ID = Convert.ToInt32(manager_ID);
            AnEmployee.Hire_Date = Convert.ToDateTime(hire_Date);
            AnEmployee.Salary = Convert.ToInt32(salary);
            AnEmployee.Dep_ID = Convert.ToInt32(dep_ID);
            AnEmployee.Active = chkActive.Checked;

            clsEmployeeCollection EmployeeList = new clsEmployeeCollection();

            if (Convert.ToInt32(emp_ID) == -1)
            {
                EmployeeList.ThisEmployee = AnEmployee;
                EmployeeList.Add();
            }
            else
            {
                EmployeeList.ThisEmployee.Find(Convert.ToInt32(emp_ID));
                EmployeeList.ThisEmployee = AnEmployee;
                EmployeeList.Update();
            }
            Response.Redirect("DefaultEmployee.aspx");
        }
        else
        {
            lblError.Text = Error;
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
        Response.Redirect("DefaultEmployee.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsEmployee AnEmployee = new ClsEmployee();
        Int32 emp_ID;
        Boolean Found = false;
        if (txtemp_ID.Text != "") {
            emp_ID = Convert.ToInt32(txtemp_ID.Text);
            Found = AnEmployee.Find(emp_ID);
        }
        else
        {
            lblError.Text = "Please enter a employee ID";
        }

        if (Found == true)
        {
            lblError.Text = "";
            txtemp_Name.Text = AnEmployee.Emp_Name;
            txtjob_Name.Text = AnEmployee.Job_Name;
            txtmanager_ID.Text = AnEmployee.Manager_ID.ToString();
            txthire_Date.Text = AnEmployee.Hire_Date.ToString();
            txtsalary.Text = AnEmployee.Salary.ToString();
            txtdep_ID.Text = AnEmployee.Dep_ID.ToString();
            chkActive.Checked = AnEmployee.Active;
        }
    }

}