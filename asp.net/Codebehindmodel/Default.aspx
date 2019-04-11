<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Fvalue:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
       <asp:Label ID="Label2" runat="server" Text="Svalue"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Option:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"> 
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Sub</asp:ListItem>
            <asp:ListItem>Mul</asp:ListItem>
            <asp:ListItem>Div</asp:ListItem>
        </asp:DropDownList>
        <br />
        <hr />
        <asp:Label ID="Label4" runat="server" Text="Result:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
