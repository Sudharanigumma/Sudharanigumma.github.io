<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MultiView</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:MultiView ID="MultiView1"  runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Imag1.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonN1" runat="server" Text="next" CommandName="NextView" />
            &nbsp
      <asp:Button ID="ButtonL" runat="server" Text="last" CommandName="SwitchById" CommandArgument="View" />
        </asp:View>

         <asp:View ID="View2" runat="server">
<asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Imag2.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonN2" runat="server" Text="next" CommandName="NextView" />
            &nbsp
      <asp:Button ID="ButtonP1" runat="server" Text="Previous" CommandName="PreView"/>
        </asp:View>

                 <asp:View ID="View3" runat="server">
<asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Image3.jpg" width="200" Height="200"/>
            <br />
            <asp:Button ID="ButtonF" runat="server" Text="first" CommandName="SwitchByIndex" CommandArgument="0" />
            &nbsp
      <asp:Button ID="ButtonP2" runat="server" Text="Previous" CommandName="PreView"/>
        </asp:View>
   </asp:MultiView>
    </div>
    </form>
</body>
</html>
