<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <h1>INCREMENT BY VALUE BY 1</h1>
        <asp:Label ID="label1" runat="server" Text="Value:"/>
<br />
        <br />
        <asp:Button ID="button1" runat="server" Text="INCREMENT BY 1" OnClick="button1_Click"/>
    </div>
    </form>
</body>
</html>
