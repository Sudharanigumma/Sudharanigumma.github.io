﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="USERNAME"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text="PWD"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>


        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="SignUp" OnClick="Button2_Click" />


        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>


    </div>
    </form>
</body>
</html>
