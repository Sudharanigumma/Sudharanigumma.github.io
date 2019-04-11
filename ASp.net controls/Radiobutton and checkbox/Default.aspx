<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Select option"></asp:Label>
       
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" />
        <br />
       
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit1" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="select option"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:CheckBox ID="CheckBox2" runat="server" />
        <asp:CheckBox ID="CheckBox3" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit2" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
    </form>
</body>
</html>
