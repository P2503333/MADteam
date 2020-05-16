<%@ page title="" language="C#" masterpagefile="~/EmployeeBook.master" autoeventwireup="true" inherits="Delete, App_Web_0njw5nfx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <br />
            <asp:Label ID="lblAddressNo" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this employee?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server"  style="z-index: 1;" Text="No" width="59px" OnClick="btnNo_Click" />

</asp:Content>
