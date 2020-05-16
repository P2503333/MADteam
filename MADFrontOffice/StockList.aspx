<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

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
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top: 323px; position: absolute; left: 57px;" Text="Edit" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 323px; position: absolute; left: 99px;" Text="Delete" OnClick="btnDelete_Click"/>
            <asp:Label ID="labelError" runat="server" style="z-index: 1; left: 13px; top: 406px; position: absolute; width: 309px;" Text=""></asp:Label>
            <asp:TextBox ID="txtBookName" runat="server" style="z-index: 1; left: 130px; top: 354px; position: absolute"></asp:TextBox>
            <asp:Label ID="labelSearch" runat="server" style="z-index: 1; left: 13px; top: 354px; position: absolute; width: 309px;" Text="Enter Book Name"></asp:Label>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; top: 374px; position: absolute; left: 15px;" Text="Apply" OnClick="btnApply_Click"/>
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; top: 374px; position: absolute; left: 67px;" Text="Clear" OnClick="btnClear_Click"/>
        </div>
    </form>
</body>
</html>
