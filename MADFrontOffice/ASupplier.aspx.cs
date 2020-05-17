using System;
using MADClasses;

public partial class ASupplier : System.Web.UI.Page
{
    Int32 ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Convert.ToInt32(Session["ID"]);
        if(IsPostBack == false)
        {
            if(ID != -1)
            {
                DisplaySuppliers();
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        clsSuppliers ASupplier = new clsSuppliers();

        string Name = txtName.Text;
        string Address = txtAddress.Text;
        string Email = txtEmail.Text;
        string LastDelivery = txtDelivery.Text;

        string Error = "";
        Error = ASupplier.Valid(Name, Email, Address, LastDelivery);


        if(Error == "")
        {
            ASupplier.Name = Name;
            ASupplier.Address = Address;
            ASupplier.Email = Email;
            ASupplier.LastDelivery = Convert.ToDateTime(LastDelivery);
            ASupplier.Active = cbxActive.Checked;

            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if(ID == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(ID);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }

            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            lblResult.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSuppliers ASupplier = new clsSuppliers();
        Int32 ID;
        Boolean Found = false;
        try
        {
            ID = Convert.ToInt32(txtID.Text);
            Found = ASupplier.Find(ID);
            if (Found)
            {
                txtName.Text = ASupplier.Name;
                txtEmail.Text = ASupplier.Email;
                txtDelivery.Text = Convert.ToString(ASupplier.LastDelivery.ToShortDateString());
                txtAddress.Text = ASupplier.Address;
                cbxActive.Checked = ASupplier.Active;
                lblResult.Text = "Successfully found entry " + ID;
            }
            else
            {
                lblResult.Text = "Could not find entry " + ID;
            }
        }
        catch (FormatException)
        {
            lblResult.Text = "ID must be a number";
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection SupplierCollection = new clsSupplierCollection();
        SupplierCollection.ThisSupplier.Find(ID);
        txtID.Text = Convert.ToString(ID);
        txtDelivery.Text = Convert.ToString(SupplierCollection.ThisSupplier.LastDelivery.ToShortDateString());
        txtName.Text = SupplierCollection.ThisSupplier.Name;
        txtEmail.Text = SupplierCollection.ThisSupplier.Email;
        txtAddress.Text = SupplierCollection.ThisSupplier.Address;
        cbxActive.Checked = SupplierCollection.ThisSupplier.Active;
    }
}