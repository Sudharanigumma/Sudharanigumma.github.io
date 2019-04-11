<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="Label1" runat="server" Text="PNO"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="PNAME"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="PRICE"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
