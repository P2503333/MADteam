using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class DefaultEmployee : System.Web.UI.Page
{
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayNames();
            }
        }

        void DisplayNames()
        {
            //create an instance of the Employee Collection
            clsEmployeeCollection Names = new clsEmployeeCollection();
            //set the data source to the list of names in the collection
            lstempoyees.DataSource = Names.EmployeeList;
        //set the name of the primary key
        lstempoyees.DataValueField = "emp_ID";
        //set the data field to display
        lstempoyees.DataTextField = "emp_Name";
        //bind the data to the list
        lstempoyees.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["emp_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnEmployee.aspx");
        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 emp_ID;
            //if a record has been selected from the list
            if (lstempoyees.SelectedIndex != -1)
            {
            //get the primary key value of the record to edit
            emp_ID = Convert.ToInt32(lstempoyees.SelectedValue);
                //store the data in the session object
                Session["emp_ID"] = emp_ID;
                //redirect to the edit page
                Response.Redirect("AnEmployee.aspx");
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
            Int32 emp_ID;
            //if a record has been selected from the list
            if (lstempoyees.SelectedIndex != -1)
            {
            //get the primary key value of the record to delete
            emp_ID = Convert.ToInt32(lstempoyees.SelectedValue);
                //store the data in the session object
                Session["emp_ID"] = emp_ID;
                //redirect to the delete page
                Response.Redirect("Delete.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

         protected void btnSwitch_Click(object sender, EventArgs e)
         {
        Response.Redirect("defaultDepartment.aspx");
           }

        //event handler for the apply button
        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        //event hanlder for the display all button
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }

        protected void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
