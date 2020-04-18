using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnAddress = new clsOrder();

        //get the data from the session object 
        AnOrder = (clsOrder)Session["AnOrder"];

        //display the OrderID for this entry 
        Response.Write(AnOrder.Order_ID);

    }
    protected void btnOK_Click(Object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsOrder AnOrder = new clsOrder();
        //capture the order ID
        int Order_ID = txtOrder_ID.Text;

        //capture the customerId ]
        int CustomerId = txtCustomerId.Text;

        //capture the employee id 
        int emp_ID = txtemp_ID.Text;

        //capture the Quantity 
        int Quantity = txtQuantity.Text;

        //capture the Total amount 
        float TotalAmount = txtTotalAmount.Text;

        //capture the order_date
        DateTime Order_Date = Convert.ToDateTime(txtOrder_Date.Text);

        //capture the Dispatch 
        bool Dispatch = txtDispatch.Text;
        // CAPTURE THE ISBN 
        string ISBN = txtISBN.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = AnOrder.valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
        if (Error =="")

        { 
        //capture the order ID
        AnOrder.Order_ID = txtOrder_ID.Text;

        //capture the customerId ]
        AnOrder.CustomerId = txtCustomerId.Text;

        //capture the employee id 
        AnOrder.emp_ID = txtemp_ID.Text;

        //capture the Quantity 
        AnOrder.Quantity = txtQuantity.Text;

        //capture the Total amount 
        AnOrder.TotalAmount = txtTotalAmount.Text;

        //capture the order_date
        AnOrder.Order_Date = Convert.ToDateTime(txtOrder_Date.Text);

        //capture the Dispatch 
        AnOrder.Dispatch = txtDispatch.Text;
        // CAPTURE THE ISBN 
        AnOrder.Order_ISBN = txtISBN.Text;

        //store the address in the session object 
        Session["AnOrder"] = AnOrder;

        //redirect to the viewer page 
        Response.Write("OrderViewer.aspx");
    }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
    void DisplayOrder()
    {
        clsOrder clsOrder = new clsOrder();

        AnOrder.Find(Order_ID);
        //display the data 
        txtOrder_ID.text = AnOrder.Order_ID;

    }
     // protected void btnCancel_Click(object sender, EventArgs e)
    // {
        //redirect to the main page 
       // Response.Redirect("Default.aspx");
   //}


}