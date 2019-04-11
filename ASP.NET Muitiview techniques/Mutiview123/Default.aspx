<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Deatils</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" >
       
        <asp:MultiView ID="multi1" runat="server" ActiveViewIndex="0">
            <asp:View ID="PersonalDeatils" runat="server">
                <asp:Label ID="label1" runat="server" Text="Fname:"></asp:Label>
                <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="label2" runat="server" Text="Lname:"></asp:Label>
                <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="label3" runat="server" Text="DOB:"></asp:Label>
                <asp:TextBox ID="textbox3" runat="server"></asp:TextBox>
                <br />
                    <asp:Label ID="label4" runat="server" Text="Gender:"></asp:Label>
                <asp:RadioButtonList ID="radiobutton1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
             <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="buttonN1" runat="server" Text="Next" OnClick="buttonN1_Click" />
            </asp:View>
            <asp:View ID="AddressDeatils" runat="server">
                <asp:Label ID="label5" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="textbox4" runat="server" Columns="70" Rows="3"></asp:TextBox>
                <br />
                <asp:Label ID="label6" runat="server" Text="city:"></asp:Label>
                <asp:TextBox ID="textbox5" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="label7" runat="server" Text="pincode:"></asp:Label>
                <asp:TextBox ID="textbox6" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="label8" runat="server" Text="state:"></asp:Label>
                <asp:TextBox ID="textbox7" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="buttonN2" runat="server" Text="Next" OnClick="buttonN2_Click" />
                &nbsp
                <asp:Button ID="buttonP1" runat="server" Text="Privious" OnClick="buttonP1_Click" />
            </asp:View>
            <asp:View ID="ContactDeatails" runat="server">
                <asp:Label ID="label9" runat="server" Text="Email ID:"></asp:Label>
                <asp:TextBox ID="textbox8" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="label10" runat="server" Text="Mobile Number:"></asp:Label>
                <asp:TextBox ID="textbox9" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="buttonF" runat="server" Text="Finish" OnClick="buttonF_Click" />
                &nbsp
                <asp:Button ID="buttonP2" runat="server" Text="Previous" OnClick="buttonP2_Click" />
 </asp:View>
            <asp:View ID="YourDeatails" runat="server">
                <asp:Label ID="label11" runat="server" ></asp:Label>
                <br />
                <asp:Label ID="label12" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label13" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label14" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label15" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label16" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label17" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label18" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label19" runat="server"></asp:Label>
                <br />
                <asp:Label ID="label20" runat="server"></asp:Label>
                <br />

                <asp:Button ID="Buttonf2" runat="server" Text="Finish" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Buttonp3" runat="server" Text="Previous" OnClick="Buttonp3_Click" />
                
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
