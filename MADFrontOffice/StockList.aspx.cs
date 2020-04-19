using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            MADClasses.clsStockCollection Stock = new MADClasses.clsStockCollection();
            lstStockList.DataSource = Stock.StockList;
            lstStockList.DataValueField = "ISBN";
            lstStockList.DataTextField = "BookName";
            lstStockList.DataBind();
        }

        /*void DisplayStockList()
        {
            MADClasses.clsStockCollection Stock = new MADClasses.clsStockCollection();
            lstStockList.DataSource = Stock.StockList;
            lstStockList.DataValueField = "ISBN";
            lstStockList.DataTextField = "BookName";
            lstStockList.DataBind();
        }*/
  

    }
    //event handler for add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ISBN"] = "0";
        //redirect to data entry page
        Response.Redirect("ABook.aspx");
    }





    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string ISBN;

        if (lstStockList.SelectedIndex != -1)
        {
            ISBN = lstStockList.SelectedValue;
            Session["ISBN"] = ISBN;
            Response.Redirect("DeleteStock.aspx");
        }

        else
        {
            labelError.Text = "Please select a record from the list to delete";

;        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        string ISBN;
        if (lstStockList.SelectedIndex != -1)
        {
            ISBN = lstStockList.SelectedValue;
            Session["ISBN"] = ISBN;
            Response.Redirect("ABook.aspx");
        }

        else
        {
            labelError.Text = "Please select a record from the list to edit";

            ;
        }
    }
}