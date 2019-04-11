<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hidden Field</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Label ID="Labele" runat="server" Text="value is:" />
        <br />
        <asp:HiddenField ID="Hidden1" runat="server" />
<br />
        <asp:Button ID="button1" runat="server" Text="Increment by 1" OnClick="button1_Click" />             
    </div>
    </form>
</body>
</html>
