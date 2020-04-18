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
        //if this is the first time page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        //create an instance of the county collection 
        Class_Library.clsOrderCollection Orders = new Class_Library.clsOrderCollection();

        //set the date source to the list of countries in the collection
        lstOrders.DataSource = Orders.OrderList;

        //set the name of the primary key 
        lstOrders.DataValueField = "OrderID";

        //set the data field to display
        lstOrders.DateTextField = "CustomerID";

        //blind the date to the list 
        lstOrders.DataBind();



    }
}