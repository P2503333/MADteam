using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class deleteD : System.Web.UI.Page
{

    //var to store the primary key value of the record to be deleted
    Int32 dep_ID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the employee to be deleted from the session object
        dep_ID = Convert.ToInt32(Session["dep_ID"]);
    }

    //event handler for the yes button

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteDepartment();
        //redirect back to the main page
        Response.Redirect("DefaultDepartment.aspx");
    }

    //event handler for the no button
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("DefaultDepartment.aspx");
    }

    void DeleteDepartment()
    {
        //function to delete the selected record

        //create a new instance of the address book
        clsDepartmentCollection departmentBook = new clsDepartmentCollection();
        //find the record to delete
        departmentBook.ThisDepartment.Find(dep_ID);
        //delete the record
        departmentBook.Delete();
    }


}