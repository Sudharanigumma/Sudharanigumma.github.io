<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div align="center">
    <asp:MultiView ID="MultiView1"  runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Imag1.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonN1" runat="server" Text="next" OnClick="ButtonN1_Click"  />
            &nbsp
      <asp:Button ID="ButtonL" runat="server" Text="last" OnClick="ButtonL_Click"  /> 
        </asp:View>

         <asp:View ID="View2" runat="server">
<asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Imag2.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonN2" runat="server" Text="next" OnClick="ButtonN2_Click"  />
            &nbsp
      <asp:Button ID="ButtonP1" runat="server" Text="Previous" OnClick="ButtonP1_Click" />
        </asp:View>

                 <asp:View ID="View3" runat="server">
<asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Image3.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonF" runat="server" Text="first" OnClick="ButtonF_Click" />
            &nbsp
      <asp:Button ID="ButtonP2" runat="server" Text="Previous" OnClick="ButtonP2_Click" />
                     <br />
                     <br />
                     <br />
                     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:View>
   </asp:MultiView>
    </div>
    </form>
</body>
</html>
