<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeBook.master" AutoEventWireup="true" CodeFile="deleteD.aspx.cs" Inherits="deleteD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <br />
            <asp:Label ID="lbldep_ID" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this department?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server"  style="z-index: 1;" Text="No" width="59px" OnClick="btnNo_Click" />

</asp:Content>
