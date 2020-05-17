using MADClasses;
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
            DisplayStock();
        }




    }

    private void DisplayStock()
    {
        MADClasses.clsStockCollection Stock = new MADClasses.clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "BookName";
        lstStockList.DataBind();
    }

    //event handler for add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to data entry page
        Response.Redirect("ABook.aspx");
    }





    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int StockID;

        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("DeleteStock.aspx");
        }

        else
        {
            labelError.Text = "Please select a record from the list to delete";

            ;
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int StockID;
        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("ABook.aspx");
        }

        else
        {
            labelError.Text = "Please select a record from the list to edit";

            ;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Books = new clsStockCollection();
        Books.ReportByBookName(txtBookName.Text);
        lstStockList.DataSource = Books.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "BookName";
        lstStockList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Books = new clsStockCollection();
        Books.ReportByBookName("");
        txtBookName.Text = "";
        lstStockList.DataSource = Books.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "BookName";
        lstStockList.DataBind();

    }
}