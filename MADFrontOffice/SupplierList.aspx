<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="SupplierList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 34px; top: 30px; position: absolute; height: 400px; width: 420px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 38px; top: 432px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 80px; top: 432px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 538px; position: absolute; height: 29px; width: 410px" Text=""></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 148px; top: 433px; position: absolute" Text="Edit" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 42px; top: 467px; position: absolute" Text="Enter a name:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 136px; top: 467px; position: absolute; width: 306px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 38px; top: 500px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 96px; top: 500px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
