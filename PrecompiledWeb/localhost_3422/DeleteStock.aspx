<%@ page language="C#" autoeventwireup="true" inherits="DeleteStock, App_Web_1j2mx5sq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 69px; width: 303px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; top: 47px; position: absolute; left: 28px;" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; top: 47px; position: absolute; left: 70px; right: 1415px;" Text="No" />
            <asp:Label ID="labelSure" runat="server" style="z-index: 1; left: 28px; top: 21px; position: absolute; width: 309px;" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
    </form>
</body>
</html>
