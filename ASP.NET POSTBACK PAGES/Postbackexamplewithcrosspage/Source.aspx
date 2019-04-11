<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crosspage post back example</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>CrossPage Postback</h1>
    <div>
    <b>enter fname:</b><asp:TextBox ID="txtFN" runat="server" AutoPostBack="True" />
        <br />
        <b>enter lname:</b><asp:TextBox ID="txtLN" runat="server" AutoPostBack="True" />
        <br />
        <asp:Button ID="btnsub" runat="server" Text="submit" PostBackUrl="~/Target.aspx" />
    </div>
    </form>
</body>
</html>
