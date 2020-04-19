<%@ page language="C#" autoeventwireup="true" inherits="ABook, App_Web_1j2mx5sq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 469px; width: 224px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtISBN" runat="server" style="z-index: 1; left: 102px; top: 44px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 102px; top: 68px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 102px; top: 92px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockLevel" runat="server" style="z-index: 1; left: 102px; top: 116px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBookName" runat="server" style="z-index: 1; left: 102px; top: 140px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 102px; top: 164px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAuthor" runat="server" style="z-index: 1; left: 102px; top: 188px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkOnOrder" runat="server" style="z-index: 1; left: 123px; top: 224px; position: absolute" Text = "On Order" />
        <asp:Label ID="LabelISBN" runat="server" style="z-index: 1; left: 20px; top: 45px; position: absolute" Text="ISBN"></asp:Label>
        <asp:Label ID="LabelPrice" runat="server" style="z-index: 1; left: 20px; top: 69px; position: absolute; right: 1375px" Text="Price"></asp:Label>
        <asp:Label ID="LabelSupplierId" runat="server" style="z-index: 1; left: 20px; top: 93px; position: absolute" Text="Supplier Id"></asp:Label>
        <asp:Label ID="LabelStock" runat="server" style="z-index: 1; left: 20px; top: 117px; position: absolute" Text="Stock Level"></asp:Label>
        <asp:Label ID="LabelBookName" runat="server" style="z-index: 1; left: 20px; top: 141px; position: absolute" Text="Book Name"></asp:Label>
        <asp:Label ID="LabelReleaseDate" runat="server" style="z-index: 1; left: 20px; top: 165px; position: absolute" Text="Release Date"></asp:Label>
        <asp:Label ID="LabelAuthor" runat="server" style="z-index: 1; left: 20px; top: 189px; position: absolute" Text="Author"></asp:Label>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 18px; top: 316px; position: absolute; width: 211px; height: 130px;" Text=""></asp:Label>
        <asp:Button ID="BtnOK" runat="server" style="z-index: 1; left: 18px; top: 286px; position: absolute" Text="OK" OnClick ="BtnOK_Click"/>
        <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; top: 286px; position: absolute; left: 58px" Text="Cancel" />
    </form>
</body>
</html>
