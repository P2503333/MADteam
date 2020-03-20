using System;
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
        clsSuppliers ASupplier = new clsSuppliers();
        Int32 ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtID.Text);
        Found = ASupplier.Find(ID);
        if (Found)
        {
            txtName.Text = ASupplier.Name;
            txtEmail.Text = ASupplier.Email;
            txtDelivery.Text = Convert.ToString(ASupplier.LastDelivery);
            txtAddress.Text = ASupplier.Address;
            cbxActive.Checked = ASupplier.Active;
            lblResult.Text = "Successfully found entry " + ID;
        }
        else
        {
            lblResult.Text = "Could not find entry " + ID;
        }
    }
}