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
        TextBox1.Focus();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Add")
        {
            int a = int.Parse(TextBox1.Text.Trim());
            int b = int.Parse(TextBox2.Text.Trim());
            int z = a + b;
            TextBox3.Text = z.ToString();
        }
        if (DropDownList1.SelectedValue == "Sub")
        {
            int a = int.Parse(TextBox1.Text.Trim());
            int b = int.Parse(TextBox2.Text.Trim());
            int z = a - b;
            TextBox3.Text = z.ToString();
        }
        if (DropDownList1.SelectedValue == "Mul")
        {
            int a = int.Parse(TextBox1.Text.Trim());
            int b = int.Parse(TextBox2.Text.Trim());
            int z = a * b;
            TextBox3.Text = z.ToString();
        }
        if (DropDownList1.SelectedValue == "Div")
        {
            int a = int.Parse(TextBox1.Text.Trim());
            int b = int.Parse(TextBox2.Text.Trim());
            int z = a / b;
            TextBox3.Text = z.ToString();
        }
    }
}