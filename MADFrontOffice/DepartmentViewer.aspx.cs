using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class DepartmentViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsDepartment ADepartment = new clsDepartment();
        ADepartment = (clsDepartment)Session["ADepartment"];
        Response.Write(ADepartment.Dep_ID);
    }
}