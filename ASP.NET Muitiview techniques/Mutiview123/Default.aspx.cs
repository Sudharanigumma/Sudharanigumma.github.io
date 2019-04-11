using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 0;
    }


    protected void buttonN1_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 1;
    }

    protected void buttonN2_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 2;
    }

    protected void buttonP1_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 0;
    }


    protected void buttonF_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 3;
        label11.Text = "<b>fname====><b>" + textbox1.Text;
        label12.Text = "<b>Lname===></b>" + textbox2.Text;
        label13.Text = "<b>Dob===></b>" + textbox3.Text;
        label14.Text = "<b>Gender====></b>" + radiobutton1.SelectedItem.Text;
        label15.Text = "<b>addres====></b>" + textbox4.Text;
        label16.Text = "<b>city====></b>" + textbox5.Text;
        label17.Text = "<b>pincode===></b>" + textbox6.Text;
        label18.Text = "<b>state===></b>" + textbox7.Text;
        label19.Text = "<b>Email Id====></b>" + textbox8.Text;
        label20.Text = "<b>Mobile No====></b>" + textbox9.Text;
    }


    protected void buttonP2_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 1;
    }


    protected void Buttonp3_Click(object sender, EventArgs e)
    {
        multi1.ActiveViewIndex = 2;
    }
}