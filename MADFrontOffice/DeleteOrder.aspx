﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="Yes" runat="server" Text="Yes" />
            &nbsp;&nbsp;
            <asp:Button ID="No" runat="server" Text="No" Width="47px" />
            <br />
        </div>
    </form>
</body>
</html>
