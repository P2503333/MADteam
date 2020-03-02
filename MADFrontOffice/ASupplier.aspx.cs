using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class ASupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clsSuppliers ASupplier = new clsSuppliers();
        //ASupplier = (clsSuppliers)Session["ASupplier"];
        //Response.Write(ASupplier.Name);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsSuppliers ASupplier = new clsSuppliers
        {
            ID = Convert.ToInt32(txtID.Text),
            Name = txtName.Text,
            Address = txtAddress.Text,
            Email = txtEmail.Text,
            LastDelivery = Convert.ToDateTime(txtDelivery.Text),
            Active = cbxActive.Enabled
        };
        Session["ASupplier"] = ASupplier;
        Response.Redirect("SupplierViewer.aspx");
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}