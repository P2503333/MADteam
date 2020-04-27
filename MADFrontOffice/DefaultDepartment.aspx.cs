using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class DefaultDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayLocation();
        }
    }

    void DisplayLocation()
    {
        //create an instance of the Employee Collection
        clsDepartmentCollection Locations = new clsDepartmentCollection();
        //set the data source to the list of names in the collection
        lstdepartment.DataSource = Locations.DepartmentList;
        //set the name of the primary key
        lstdepartment.DataValueField = "dep_ID";
        //set the data field to display
        lstdepartment.DataTextField = "dep_Name";
        //bind the data to the list
        lstdepartment.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["dep_ID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ADepartment.aspx");
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 dep_ID;
        //if a record has been selected from the list
        if (lstdepartment.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            dep_ID = Convert.ToInt32(lstdepartment.SelectedValue);
            //store the data in the session object
            Session["dep_ID"] = dep_ID;
            //redirect to the edit page
            Response.Redirect("ADepartment.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 dep_ID;
        //if a record has been selected from the list
        if (lstdepartment.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            dep_ID = Convert.ToInt32(lstdepartment.SelectedValue);
            //store the data in the session object
            Session["emp_ID"] = dep_ID;
            //redirect to the delete page
            Response.Redirect("DeleteD.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnSwitch_Click(object sender, EventArgs e)
    {
        Response.Redirect("defaultEmployee.aspx");
    }

    //event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    //event hanlder for the display all button
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void lstDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}