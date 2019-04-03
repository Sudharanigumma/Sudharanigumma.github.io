<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
        <asp:BulletedList ID="BulletedList1" runat="server"  OnClick="BulletedList1_Click" BulletStyle="Numbered" DisplayMode="LinkButton">
            <asp:ListItem Value="csharp">CSHARP</asp:ListItem>
            <asp:ListItem Value="PHP">PHP</asp:ListItem>
            <asp:ListItem Value="ASP.NET">ASP.NET</asp:ListItem>
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
