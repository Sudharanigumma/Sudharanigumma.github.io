<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="Label1" runat="server" Text="FNAME"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <br />
        <br />
               <asp:Label ID="Label2" runat="server" Text="LNAME"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      <br />
        <br />
               <asp:Label ID="Label3" runat="server" Text="USERNAME"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
      <br />
        <br />
               <asp:Label ID="Label4" runat="server" Text="PWD"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
      <br />
        <br />
               <asp:Label ID="Label5" runat="server" Text="ADDRES"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
      <br />
        <br />


        <br />
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="Button2" runat="server" Text="SignIn" OnClick="Button2_Click" />


        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>


    </div>
    </form>
</body>
</html>
