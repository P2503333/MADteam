<%@  Page Title="" Language="C#" MasterPageFile="~/EmployeeBook.master" AutoEventWireup="true" CodeFile="DefaultDepartment.aspx.cs" Inherits="DefaultDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
            <asp:ListBox ID="lstdepartment" runat="server" style="z-index: 1; height: 197px; width: 327px" OnSelectedIndexChanged="lstDepartment_SelectedIndexChanged"></asp:ListBox>
                        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblLocation" runat="server" style="z-index: 1; width: 317px" Text="Please Enter an Department Location"></asp:Label>
            <br />
            <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; width: 119px" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" height="26px" style="z-index: 1; width: 119px" Text="Display All" OnClick="btnDisplayAll_Click"/>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; " Text="Add" height="26px" width="55px" OnClick="btnAdd_Click"  />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; " Text="Edit" height="26px" width="55px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; right: 249px" Text="Delete" height="26px" width="55px"/>
            <br />
            <asp:Button ID="btnSwitch" runat="server" OnClick="btnSwitch_Click" style="z-index: 1; right: 249px" Text="Switch to employee Pane" height="26px" width="289px"/>
    </asp:Content>
