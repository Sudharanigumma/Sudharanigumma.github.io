<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Label ID="Lablef" runat="server" Text="Fname" />
        <asp:TextBox ID="TextBox1" runat="server" />
        <br />
        <br />
           <asp:Label ID="Labell" runat="server" Text="Lname" />
        <asp:TextBox ID="TextBox2" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
     </div>
    </form>
</body>
</html>
