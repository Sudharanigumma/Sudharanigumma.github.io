<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Label ID="Labelf" runat="server" Text="Enter Fname:"/>
        <asp:TextBox ID="Textbox1" runat="server" />
        <br />
        <br />
    <asp:Label ID="Labell" runat="server" Text="Enter Lname:"/>
        <asp:TextBox ID="Textbox2" runat="server" />
<br/ />
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        <br />
        <br />
       <asp:Label ID="Label1" runat="server" Text=" "/>
        <br />
        <br/ />
         <asp:Label ID="Label2" runat="server" Text=" "/>
    </div>
    </form>
</body>
</html>
