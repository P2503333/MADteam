using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // creat a new instance of clsAddress
        clsOrder clsOrder = new clsOrder();

        //capture the Order_ID 
        AnOrder.Order_ID = txtOrder_ID.Text;

        // store the address in the session Object 
        Session["AnOrder"] = AnOrder;

        //redirect to the viewer page 
        Response.Redirect("Address Viewer.aspx");

    }
}