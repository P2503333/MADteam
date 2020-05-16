using MADClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();

        }
    }
    void DisplayOrders()
    {
        //create an instance of the order collection 
        MADClasses.clsOrderCollection Orders = new MADClasses.clsOrderCollection();
        //set the data dource to the list of countries in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key 
        lstOrderList.DataValueField = "Order_ID";
        //set the data field to display
        lstOrderList.DataTextField = "Quanity";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(Object sender, EventArgs e)
    {
        Session["Order_ID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("AnOrder.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Order_ID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            Order_ID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["Order_ID"] = Order_ID;
            //redirect to the delet page 
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        //if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be edited
        Int32 Order_ID;
        //if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            Order_ID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["Order_ID"] = Order_ID;
            //redirect to the edit page 
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            //display  an error 
            lblError.Text = "Please select a record to delete from the list";
        }

    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create aninstance of the order collection 
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByQuantity(Convert.ToInt32(txtFilter.Text));
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key 
        lstOrderList.DataValueField = "Order_ID";
        //set the name of the field to display 
        lstOrderList.DataTextField = "Quantity";
        lstOrderList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByQuantity(-1);
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "Order_ID";
        lstOrderList.DataTextField = "Quantity";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}