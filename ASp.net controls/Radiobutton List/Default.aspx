<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="SELECT OPTION:"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Images1" Height="100px" Width="100px" runat="server" ImageUrl="~/img/images.jpg"/>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="Engineer">ENGINEER</asp:ListItem>
            <asp:ListItem Value="doctor">Doctor</asp:ListItem>
            <asp:ListItem Value="bse">BSE</asp:ListItem>
            <asp:ListItem Value="Bca">BCA</asp:ListItem>
            <asp:ListItem Value="Actor">ACTOR</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
