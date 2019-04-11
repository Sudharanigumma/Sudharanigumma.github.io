<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
          
        <asp:Label ID="Label1" runat="server" Text="Enter the Paasword:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Password should contain atlieast one lower,uppercharacter,one numerc and range between 6 to 22" ControlToValidate="TextBox1" OnServerValidate="CustomValidator1_ServerValidate" ></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
          
    </div>
    </form>
</body>
</html>
