<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Order ID&nbsp;
            <asp:TextBox ID="txtOrder_ID" runat="server" Height="17px" style="margin-left: 124px" Width="183px"></asp:TextBox>
            <br />
            <br />
            Customer ID&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerNo" runat="server" Height="21px" style="margin-left: 99px" Width="178px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <br />
            Employee ID&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtemp_ID" runat="server" Height="17px" style="margin-left: 93px" Width="178px"></asp:TextBox>
            <br />
            <br />
            Quantity&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" Height="17px" style="margin-left: 124px" Width="183px"></asp:TextBox>
            <br />
            <br />
            TotalAmount
            <asp:TextBox ID="txtTotalAmount" runat="server" Height="17px" style="margin-left: 109px" Width="183px"></asp:TextBox>
            <br />
            <br />
            Order_date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrder_Date" runat="server" Height="17px" style="margin-left: 59px" Width="183px"></asp:TextBox>
            <br />
            <br />
            Dispatch 
            <asp:TextBox ID="txtDispatch" runat="server" Height="17px" style="margin-left: 141px" Width="183px"></asp:TextBox>
            <br />
            <br />
            <br />
            ISBN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextISBN" runat="server" Width="183px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Confirm Order" style="margin-left: 117px" Width="130px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" style="margin-left: 116px" Width="130px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
