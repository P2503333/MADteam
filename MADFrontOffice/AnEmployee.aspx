<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnEmployee.aspx.cs" Inherits="AnEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Empoyee ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemp_ID" runat="server"></asp:TextBox>
            <br />
            Employee Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemp_Name" runat="server"></asp:TextBox>
            <br />
            Job Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtjob_Name" runat="server"></asp:TextBox>
            <br />
            Manager ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtmanager_ID" runat="server"></asp:TextBox>
            <br />
            Hire Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txthire_Date" runat="server"></asp:TextBox>
            <br />
            Salary&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
            <br />
            Department ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtdep_ID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="active" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />


        </div>
    </form>
</body>
</html>
