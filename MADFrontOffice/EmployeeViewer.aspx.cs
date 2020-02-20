using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class EmployeeViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsEmployee AnEmployee = new ClsEmployee();
        AnEmployee = (ClsEmployee)Session["AnEmployee"];
        Response.Write(AnEmployee.Emp_ID);
    }
}