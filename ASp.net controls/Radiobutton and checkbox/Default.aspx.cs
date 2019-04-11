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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RadioButton1.Checked)
            {
            Label3.Text = "<b>your selected option is:</b>" + RadioButton1.Text;
            }
        else if(RadioButton2.Checked)
            {
            {
                Label3.Text = "<b>your selected option is:</b>" + RadioButton2.Text;
            }
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        string selectedopt = string.Empty;
        if (CheckBox1.Checked)
        {
           selectedopt+=CheckBox1.Text+ " , ";
        }
        if (CheckBox2.Checked)
        {
            selectedopt += CheckBox2.Text + " , ";
        }
        if (CheckBox3.Checked)
        {
            selectedopt += CheckBox3.Text + " , ";
        }
        Label3.Text = "<b>your selectedoption are:</b>" + selectedopt;
    }
}