<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }
      protected void Button1_Click(object sender, EventArgs e)
    {
        int a = int.Parse(TextBox1.Text.Trim());
        int b = int.Parse(TextBox2.Text.Trim());
        int z=a+b;
        TextBox3.Text=z.ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int a = int.Parse(TextBox1.Text.Trim());
        int b = int.Parse(TextBox2.Text.Trim());
        int z=a-b;
        TextBox3.Text=z.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int a = int.Parse(TextBox1.Text.Trim());
        int b = int.Parse(TextBox2.Text.Trim());
        int z=a*b;
        TextBox3.Text=z.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int a = int.Parse(TextBox1.Text.Trim());
        int b = int.Parse(TextBox2.Text.Trim());
        int z=a/b;
        TextBox3.Text=z.ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Math</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Fvalue:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Svalue"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Mul" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Div" OnClick="Button4_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Reset:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
