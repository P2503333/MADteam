<%@  Page Title="" Page Language="C#" MasterPageFile="~/EmployeeBook.master" AutoEventWireup="true" CodeFile="AnEmployee.aspx.cs" Inherits="AnEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblemp_ID" runat="server" Text="Employee ID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtemp_ID" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblemp_Name" runat="server" Text="Employee Name" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtemp_Name" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lbljob_Name" runat="server"  Text="Job Name" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtjob_Name" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblmanager_ID" runat="server" Text="Manager ID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtmanager_ID" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblhire_Date" runat="server" Text="Hire Date" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txthire_Date" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblsalary" runat="server" Text="Salary" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtsalary" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lbldep_ID" runat="server" Text="Department ID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtdep_ID" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />

</asp:Content>
