<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="selectd option is:"></asp:Label>
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="csharp">Csharp</asp:ListItem>
            <asp:ListItem Value="HTML">HTML</asp:ListItem>
            <asp:ListItem Value="PHP">PHP</asp:ListItem>
            <asp:ListItem Value="SQL">SQL</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
