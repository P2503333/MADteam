<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:Label ID="Order_ID" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrder_ID" runat="server" Height="17px" style="margin-left: 122px" Width="183px"></asp:TextBox>
            <br />
            <br />
            &nbsp;
            
         <asp:Label ID="CustomerID" runat="server" Text="Customer ID"></asp:Label> &nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerNo" runat="server" Height="21px" style="margin-left: 84px" Width="178px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <br />
            &nbsp;<asp:Label ID="emp_ID" runat="server" Text="Employee ID"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtemp_ID" runat="server" Height="17px" style="margin-left: 86px" Width="178px"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="Quantity" runat="server" Text="Quantity"></asp:Label>
            &nbsp;<asp:TextBox ID="txtQuantity" runat="server" Height="17px" style="margin-left: 124px" Width="183px"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Label ID="TotalAmount" runat="server" Text="TotalAmount"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" Height="17px" style="margin-left: 101px" Width="183px"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="Order_Date" runat="server" Text="Order_Date"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrder_Date" runat="server" Height="17px" style="margin-left: 59px" Width="183px"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="Dispatch" runat="server" Text="Dispatch"></asp:Label>
&nbsp;<asp:TextBox ID="txtDispatch" runat="server" Height="17px" style="margin-left: 141px" Width="183px"></asp:TextBox>
            <br />
            <br />&nbsp;
            &nbsp;

            <asp:Label ID="ISBN" runat="server" Text="ISBN"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 162px" Width="185px"></asp:TextBox>
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
