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
        Response.Write(anEmployee.Emp_ID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsEmployee anEmployee = new ClsEmployee();

        anEmployee.Emp_ID = txtemp_ID.Text;
        anEmployee.Emp_Name = txtemp_Name.Text;
        anEmployee.Job_Name = txtjob_Name.Text;
        anEmployee.Manager_ID = txtmanager_ID.Text;
        anEmployee.Hire_Date = Convert.ToDateTime( txthire_Date.Text);
        anEmployee.Salary = txtsalary.Text;
        anEmployee.Dep_ID = txtdep_ID.Text;
        anEmployee.Active = txtactive.Text;
        Session["AnEmployee"] = anEmployee;

        Response.Write("EmployeeViewer.aspx");
    }
    void DisplayEmployee()
    {
        ClsEmployee anEmployee= new ClsEmployee();

        anEmployee.Find(emp_ID);
        //display the data
        txtemp_ID.Text = anEmployee.Emp_ID;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }
}