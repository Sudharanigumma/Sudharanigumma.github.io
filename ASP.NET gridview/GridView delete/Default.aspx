<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:GridView ID="Gridproduct" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="true" OnRowCancelingEdit="Gridproduct_RowCancelingEdit" OnRowEditing="Gridproduct_RowEditing" OnRowUpdating="Gridproduct_RowUpdating">
           <Columns>
               <asp:TemplateField HeaderText="EID">
                   <ItemTemplate>
                       <asp:Label ID="Labeleid" runat="server" Text='<%#Eval("EID") %>'/>
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
                       <asp:TextBox ID="texno" runat="server" Text='<%#Eval ("SALARY") %>' />
                   </EditItemTemplate>
               </asp:TemplateField>
           </Columns>
        </asp:GridView>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
