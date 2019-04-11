<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        
    
        <asp:Label ID="Label1" runat="server" Text="EID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="ENAME:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="SALARY:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="SHOW" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="NEW" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="INSERT" OnClick="Button3_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="DELETE" OnClick="Button4_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="UPDATE" OnClick="Button5_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridEmp" runat="server" AutoGenerateColumns="false" Width="16px" OnRowCancelingEdit="GridEmp_RowCancelingEdit" OnRowEditing="GridEmp_RowEditing" OnRowUpdating="GridEmp_RowUpdating" OnRowDeleting="GridEmp_RowDeleting">
            <Columns>
            
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
                <asp:BoundField DataField="EID" HeaderText="EID" />
                   <asp:BoundField DataField="ENAME" HeaderText="ENAME" />
                   <asp:BoundField DataField="SALARY" HeaderText="SALARY" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
