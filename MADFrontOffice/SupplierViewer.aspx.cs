using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MADClasses;

public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSuppliers ASupplier = new clsSuppliers();
        ASupplier = (clsSuppliers)Session["ASupplier"];
        Response.Write(ASupplier.ID);
        Response.Write(ASupplier.Name);
        Response.Write(ASupplier.Address);
        Response.Write(ASupplier.Email);
        Response.Write(ASupplier.LastDelivery);
        Response.Write(ASupplier.Active);
    }
}