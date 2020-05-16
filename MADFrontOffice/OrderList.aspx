<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:listbox ID="lstOrderList" runat="server" Height="171px" Width="421px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:listbox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add"  Width="51px"/>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="49px" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="58px" />
            </p>
        <p>
            &nbsp;Enter a Quantity&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" Height="24px" OnTextChanged="txtQuantity_TextChanged"></asp:TextBox>
            
            </p>
        <p>
            <asp:Button ID="Apply" runat="server" Text="Apply" /> 
            
            &nbsp;&nbsp;
            <asp:Button ID="Clear" runat="server" Text="Clear" />
            
            </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
