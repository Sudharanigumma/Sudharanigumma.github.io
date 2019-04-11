<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Emp.aspx.cs" Inherits="Emp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emp</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Empno:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
        </asp:DropDownList>
    
   <br />
        <asp:Button ID="Button1" runat="server" Text="Show details" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ename:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Salary:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
