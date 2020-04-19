using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class ABook : System.Web.UI.Page
{
    string nISBN; 
    protected void Page_Load(object sender, EventArgs e)
    {
        nISBN = Convert.ToString(Session["ISBN"]);
        if (IsPostBack == false)
        {
            if (nISBN != "0")
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection allStock = new clsStockCollection();
        allStock.ThisStock.Find(nISBN);
        txtISBN.Text = allStock.ThisStock.ISBN;
        txtPrice.Text = allStock.ThisStock.Price.ToString();
        txtSupplierID.Text = allStock.ThisStock.SupplierID.ToString();
        txtStockLevel.Text = allStock.ThisStock.StockLevel.ToString();
        txtAuthor.Text = allStock.ThisStock.Author;
        txtBookName.Text = allStock.ThisStock.BookName;
        txtReleaseDate.Text = allStock.ThisStock.ReleaseDate.ToString();
        chkOnOrder.Checked = allStock.ThisStock.OnOrder;

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //new instance of the stock class
        clsStock ABook = new clsStock();
        //Capture the input fields
        string ISBN = txtISBN.Text;
        string Price = txtPrice.Text;
        string SupplierID = txtSupplierID.Text;
        string StockLevel = txtStockLevel.Text;
        string Author = txtAuthor.Text;
        string BookName = txtBookName.Text;
        string ReleaseDate = txtReleaseDate.Text;
        Boolean OnOrder = chkOnOrder.Checked;
        //String to contain any errors
        string Error = "";
        Error = ABook.Valid(ISBN, Price, StockLevel, BookName, Author, SupplierID, ReleaseDate);
        if (Error == "")
        {
            ABook.ISBN = ISBN;
            ABook.Price = Convert.ToDouble(Price);
            ABook.SupplierID = Convert.ToInt32(SupplierID);
            ABook.StockLevel = Convert.ToInt32(StockLevel);
            ABook.Author = Author;
            ABook.BookName = BookName;
            ABook.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            ABook.OnOrder = OnOrder;

            clsStockCollection StockList = new clsStockCollection();
            if (nISBN == "0")
            {
                StockList.ThisStock = ABook;
                StockList.Add();
                Response.Redirect("StockList.aspx");
            }
            else
            {
                StockList.ThisStock.Find(nISBN);
                StockList.ThisStock = ABook;
                StockList.Update();
            }
        }
        else
        {
            LabelError.Text = Error;
        }

    }
}