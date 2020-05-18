<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>
<script runat="server">
  
    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrder_ID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrder_ID" runat="server" Height="25px" style="margin-left: 122px" Width="183px" OnTextChanged="txtOrder_ID_TextChanged"></asp:TextBox>
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
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" style="margin-left: 117px" Width="130px" OnClick="btnOK_Click" />
            <asp:Button ID="btncancel" runat="server" Text="Cancel" style="margin-left: 116px" Width="130px" OnClick="btncancel_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
