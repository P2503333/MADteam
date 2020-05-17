<%@  Page Title="" Language="C#" MasterPageFile="~/EmployeeBook.master" AutoEventWireup="true" CodeFile="DefaultDepartment.aspx.cs" Inherits="DefaultDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
            <asp:ListBox ID="lstdepartment" runat="server" style="z-index: 1; height: 197px; width: 327px" OnSelectedIndexChanged="lstDepartment_SelectedIndexChanged"></asp:ListBox>
                        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblLocation" runat="server" style="z-index: 1; width: 317px" Text="Please enter a Department Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; " Text="Apply" OnClick="btnApply_Click" Height="24px" Width="111px" />
            <asp:Button ID="btnClear" runat="server" height="24px" style="z-index: 1; " Text="Clear" OnClick="btnClear_Click" Width="114px"/>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; " Text="Add" height="26px" width="55px" OnClick="btnAdd_Click"  />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; " Text="Edit" height="26px" width="55px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; right: 249px" Text="Delete" height="26px" width="55px"/>
            <br />
            <asp:Button ID="btnSwitch" runat="server" OnClick="btnSwitch_Click" style="z-index: 1; right: 249px" Text="Switch to Employee Pane" height="26px" width="289px"/>
    </asp:Content>
