using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class AnEmployee : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsEmployee
        ClsEmployee AnEmployee = new ClsEmployee();
        //capture the employee ID
        AnEmployee.Emp_ID = txtemp_ID.Text;
        //get the data from the session object
        AnEmployee = (ClsEmployee)Session["AnEmployee"];
        //display the employee ID for this entry
        Response.Write(AnEmployee.Emp_ID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the employee class
        ClsEmployee AnEmployee = new ClsEmployee();
        //capture the employee ID
        AnEmployee.Emp_ID = txtemp_ID.Text;
        Session["AnEmployee"] = AnEmployee;
        //redirect to the viewer page
        Response.Redirect("EmployeeViewer.aspx");
    }
}