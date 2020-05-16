<%@ page language="C#" autoeventwireup="true" inherits="ASupplier, App_Web_1j2mx5sq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 133px; top: 15px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 133px; top: 40px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 133px; top: 65px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 133px; top: 90px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDelivery" runat="server" style="z-index: 1; left: 133px; top: 115px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="SupplierID:"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 40px; position: absolute" Text="Supplier Name:"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 65px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="lblDelivery" runat="server" style="z-index: 1; left: 10px; top: 115px; position: absolute" Text="Last Delivery:"></asp:Label>
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 10px; top: 140px; position: absolute" Text="Active:"></asp:Label>
        <asp:CheckBox ID="cbxActive" runat="server" style="z-index: 1; left: 133px; top: 140px; position: absolute" />
        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" style="z-index: 1; left: 90px; top: 165px; position: absolute" Text="Test" />
        <asp:Label ID="lblResult" runat="server" style="z-index: 1; left: 10px; top: 190px; position: absolute" Text=""></asp:Label>
        <asp:Button ID="btnFind" OnClick="btnFind_Click" runat="server" style="z-index: 1; left: 133px; top: 165px; position: absolute" Text="Find" />
    </form>
</body>
</html>
