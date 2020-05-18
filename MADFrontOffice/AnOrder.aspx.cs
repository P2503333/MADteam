using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;


public partial class AnOrder : System.Web.UI.Page
{
    //variable to store the primary key page level scope
    Int32 Order_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the data from the session object
        Order_ID = Convert.ToInt32(Session["AnOrder"]);
        if (IsPostBack == false)
        {
            //if this is Not a new record
            if (Order_ID != -1)
            {
                //display the current data for the record 
                DisplayOrder();
            }
        }

        //display the OrderID for this entry 
        // Response.Write(AnOrder.Order_ID);

        //}
    }
    protected void btnOK_Click(Object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsOrder AnOrder = new clsOrder();
        //capture the order ID
        //int Order_ID = txtOrder_ID.Text;
        //capture the customerId ]
        int CustomerId = int.Parse(txtCustomerNo.Text);
        //capture the employee id 
        int emp_ID = int.Parse(txtemp_ID.Text);
        //capture the Quantity 
        int Quantity = int.Parse(txtQuantity.Text);
        //capture the Total amount 
        float TotalAmount = float.Parse(txtTotalAmount.Text);
        //capture the order_date
        DateTime Order_Date = Convert.ToDateTime(txtOrder_Date.Text);
        //capture the Dispatch 
        bool Dispatch = bool.Parse(txtDispatch.Text);
        // CAPTURE THE ISBN 
        string ISBN = txtISBN.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = AnOrder.Valid(Order_ID, CustomerId, emp_ID, Quantity, TotalAmount, Order_Date, Dispatch, ISBN);
        if (Error == "")
        {
            //capture the order ID
            //AnOrder.Order_ID = Order_ID;
            //capture the customerId ]
            AnOrder.CustomerId = CustomerId;
            //capture the employee id 
            AnOrder.emp_ID = emp_ID;
            //capture the Quantity 
            AnOrder.Quantity = Quantity;
            //capture the Total amount 
            AnOrder.TotalAmount = TotalAmount;
            //capture the order_date
            AnOrder.Order_Date = Convert.ToDateTime(Order_Date);
            //capture the Dispatch 
            AnOrder.Dispatch = Dispatch;
            // CAPTURE THE ISBN 
            AnOrder.ISBN = ISBN;
            //create a new instance of the OrderCollection
            clsOrderCollection OrderList = new clsOrderCollection();


            if (Order_ID == -1)
            {
                //set the ThisOrder property 
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Order_ID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            //redirect back to the list page 
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
    }

    void DisplayOrder()
    {
        //create an instance of the Order List
        clsOrderCollection OrderBook = new clsOrderCollection();

        //find the record to update 
        OrderBook.ThisOrder.Find(Order_ID);

        //display the data for this record
        txtOrder_ID.Text = OrderBook.ThisOrder.Order_ID.ToString();
        txtCustomerNo.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtemp_ID.Text = OrderBook.ThisOrder.emp_ID.ToString();
        txtQuantity.Text = OrderBook.ThisOrder.Quantity.ToString();
        txtTotalAmount.Text = OrderBook.ThisOrder.TotalAmount.ToString();
        txtOrder_Date.Text = OrderBook.ThisOrder.Order_Date.ToString();
        txtDispatch.Text = OrderBook.ThisOrder.Dispatch.ToString();
        txtISBN.Text = OrderBook.ThisOrder.ISBN;

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page 
        Response.Redirect("Default.aspx");
    }

    protected void btnfind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key 
        int Order_ID;
        //variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user
        Order_ID = Convert.ToInt32(txtOrder_ID.Text);
        //find the record 
        Found = AnOrder.Find(Order_ID);
        //if found 
        if (Found == true)
        {
            // display the values of the properties in the form 
            txtCustomerNo.Text = AnOrder.CustomerId.ToString();
            txtemp_ID.Text = AnOrder.emp_ID.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtOrder_Date.Text = AnOrder.Order_Date.ToString();
            txtDispatch.Text = AnOrder.Dispatch.ToString();
            txtISBN.Text = AnOrder.ISBN;
        }
    }

}

