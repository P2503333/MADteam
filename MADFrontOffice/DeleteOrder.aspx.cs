using System;
using MADClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    //var to store the primary key value of the record to be delete
    Int32 Order_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object 
        Order_ID = Convert.ToInt32(Session["Order_ID"]);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Order book 
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete 
        OrderBook.ThisOrder.Find(Order_ID);
        //delete the record 
        OrderBook.Delete();
        //redirect back to the main page 
        Response.Redirect("OrderList.aspx");
    }
}