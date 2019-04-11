using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Emp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Focus();
    }
     protected void Button1_Click(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedValue.ToString()=="10")
        {
          TextBox1.Text =  "A";
         TextBox2.Text =  "25000";
        }
       else if (DropDownList1.SelectedValue.ToString() == "20")
        {
           TextBox1.Text =  "B";
            TextBox2.Text = "35000";
        }
        if (DropDownList1.SelectedValue.ToString() == "30")
        {
            TextBox1.Text = "c";
              TextBox2.Text =  "45000";
        }
    }
}