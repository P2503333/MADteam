<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteSupplier.aspx.cs" Inherits="DisableSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 67px">
        </div>
        <asp:Label ID="lblWarning" runat="server" style="z-index: 1; left: 34px; top: 18px; position: absolute; height: 33px; width: 332px" Text="Are you sure you want to delete this supplier?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 34px; top: 48px; position: absolute; margin-top: 0px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 78px; top: 48px; position: absolute; margin-top: 0px" Text="No" />
    </form>
</body>
</html>
