using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["User"] = TextBox1.Text;
        con =new  SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7");
        cmd = new SqlCommand("select count(*) from emps where Userid='" + TextBox1.Text + "'and pwd='" + TextBox2.Text +, con);
        con.Open();
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        if(i>0)
        {
            Response.Redirect("~/Home.aspx");
        }
        else
        {
            Label3.Text="invalid credentials";
        }
    }
}