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
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Registration.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd=new SqlCommand("select count(*) from PERSONALDETAILS where USERNAME='"+TextBox3.Text+"' and " + TextBox4.Text+"");
        con.Open();
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        if (i > 0)
        {
            Response.Redirect("~/Home.aspx");
        }
        else
        {
            Label3.Text = "INVALID USER";
        }
    }
}