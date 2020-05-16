<%@ page language="C#" autoeventwireup="true" inherits="StockList, App_Web_1j2mx5sq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 15px; top: 18px; position: absolute; height: 302px; width: 316px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; top: 323px; position: absolute; left: 15px;" Text="Add" OnClick="btnAdd_Click"/>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 323px; position: absolute; left: 57px;" Text="Delete" OnClick="btnDelete_Click"/>
            <asp:Label ID="labelError" runat="server" style="z-index: 1; left: 17px; top: 351px; position: absolute; width: 309px;" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
