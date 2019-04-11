<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:GridView ID="Geditdel" runat="server" AutoGenerateColumns="false" OnRowCancelingEdit="Geditdel_RowCancelingEdit" OnRowEditing="Geditdel_RowEditing" OnRowUpdating="Geditdel_RowUpdating" OnRowDeleting="Geditdel_RowDeleting">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkbutton" runat="server" Text="Edit" CommandName="Edit" />
</ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lnkcnl" runat="server" Text="cancel" CommandName="cancel" />
                &nbsp
                <asp:LinkButton ID="lnkupd" runat="server" Text="Update" CommandName="Update" />
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="linkdel" runat="server" Text="Delete" CommandName="Delete" />
                 </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EID">
                <ItemTemplate>
                    <asp:Label ID="labeno" runat="server" Text='<%#Eval("EID") %>' />
                </ItemTemplate>
              </asp:TemplateField>
            <asp:TemplateField HeaderText="ENAME">
                <ItemTemplate>
                    <%#Eval("ENAME") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SALARY">
                <ItemTemplate>
                    <%#Eval("SALARY") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtsal" runat="server" Text='<%#Eval("SALARY") %>' />
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
