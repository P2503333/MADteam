<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void TextISBN_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnconfirmorder_Click(object sender, EventArgs e)
    {

    }

    protected void btncancel_Click(object sender, EventArgs e)
    {

    }

    protected void txtTotalAmount_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtQuantity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerNo_TextChanged(object sender, EventArgs e)
    {

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
        Order_ID = Convert.Toint(txtOrder_ID.Text);
        //find the record 
        Found = AnOrder.Find(Order_ID);
        //if found 
        if (Found == true)
        {
            // display the values of the properties in the form 
            txtOrder_ID.Text = AnOrder.CustomerId;
            txtOrder_ID.Text = AnOrder.emp_ID;
            txtOrder_ID.Text = AnOrder.Quantity;
            txtOrder_ID.Text = AnOrder.TotalAmount;
            txtOrder_ID.Text = AnOrder.Date.ToString();
            txtOrder_ID.Text = AnOrder.Dispatch.ToString()
            txtOrder_ID.Text = AnOrder.ISBN;


        }
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrder_ID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrder_ID" runat="server" Height="25px" style="margin-left: 122px" Width="183px"></asp:TextBox>
            <asp:Button ID="btnfind" runat="server" style="margin-left: 40px; height: 29px;" Text="Find" OnClick="btnfind_Click" />
            <br />
            <br />

            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label> 
            &nbsp;&nbsp; 
            <asp:TextBox ID="txtCustomerNo" runat="server" Height="25px" style="margin-left: 84px" Width="183px" OnTextChanged="txtCustomerNo_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblemp_ID" runat="server" Text="Employee ID"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtemp_ID" runat="server" Height="25px" style="margin-left: 84px" Width="183px"></asp:TextBox>
            <br />
            <br />           
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" Height="25px" style="margin-left: 130px" Width="183px" OnTextChanged="txtQuantity_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTotalAmount" runat="server" Text="TotalAmount"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" Height="25px" style="margin-left: 94px" Width="183px" OnTextChanged="txtTotalAmount_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrder_Date" runat="server" Text="Date"></asp:Label>
            <asp:TextBox ID="txtOrder_Date" runat="server" Height="25px" style="margin-left: 160px" Width="183px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDispatch" runat="server" Text="Dispatch"></asp:Label>
            <asp:TextBox ID="txtDispatch" runat="server" Height="25px" style="margin-left: 129px" Width="183px"></asp:TextBox>
            <br />
            <br />            
            <asp:Label ID="lblISBN" runat="server" Text="ISBN"></asp:Label>
            <asp:TextBox ID="txtISBN" runat="server"  Height="25px" Width="183px" style="margin-left: 157px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnconfirmorder" runat="server" Text="Confirm Order" style="margin-left: 117px" Width="130px" OnClick="btnconfirmorder_Click" />
            <asp:Button ID="btncancel" runat="server" Text="Cancel" style="margin-left: 116px" Width="130px" OnClick="btncancel_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
