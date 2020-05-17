<%@  Page Title="" Language="C#" MasterPageFile="~/EmployeeBook.master" AutoEventWireup="true" CodeFile="ADepartment.aspx.cs" Inherits="ADepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lbldep_ID" runat="server" Text="Department ID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdep_ID" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lbldep_Name" runat="server" Text="Department Name" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdep_Name" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lbldep_Location" runat="server"  Text="Department Location" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdep_Location" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblno_Employee" runat="server" Text="Number of Employees" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtno_Employee" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" height="26px" Text="Find" width="61px" OnClick="btnFind_Click" />

</asp:Content>
