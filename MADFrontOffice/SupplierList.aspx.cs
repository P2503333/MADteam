using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        MADClasses.clsSupplierCollection Suppliers = new MADClasses.clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "ID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ID"] = -1;
        Response.Redirect("ASupplier.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ID;

        if(lstSupplierList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("DeleteSupplier.aspx");
        }
        else
        {
            lblError.Text = "Please select a supplier to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ID;
        if(lstSupplierList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("ASupplier.aspx");
        }
        else
        {
            lblError.Text = "Please select a supplier to edit";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        MADClasses.clsSupplierCollection Suppliers = new MADClasses.clsSupplierCollection();
        Suppliers.Filter(txtFilter.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "ID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        MADClasses.clsSupplierCollection Suppliers = new MADClasses.clsSupplierCollection();
        Suppliers.Filter("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "ID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        /**
         * Actual order code would go here.
         * Felt like it was a little out of 
         * spec for the supplier table though
         */
    }

    protected void btnViewStock_Click(object sender, EventArgs e)
    {
        if (lstSupplierList.SelectedIndex != -1)
        {
            MADClasses.clsStockCollection Books = new MADClasses.clsStockCollection();
            Books.FilterBySupplier(Convert.ToInt32(lstSupplierList.SelectedValue));
            lstBookList.DataSource = Books.StockList;
            lstBookList.DataValueField = "BookName";
            lstBookList.DataTextField = "SupplierInfo";
            lstBookList.DataBind();
        }
        else
        {
            lblError.Text = "Please select a supplier to show";
        }
    }
}