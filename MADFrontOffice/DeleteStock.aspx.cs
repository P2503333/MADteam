using MADClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    private int StockID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection allStock = new clsStockCollection();
        allStock.ThisStock.Find(StockID);
        allStock.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
       Response.Redirect("StockList.aspx");
    }
}