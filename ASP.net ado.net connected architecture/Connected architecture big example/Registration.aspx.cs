using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
}

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd=new SqlCommand("Insert into PERSONALDETAILS values('"+TextBox1.Text+"','"+ TextBox2.Text+"','"+ TextBox3.Text+"',"+ TextBox4.Text+",'"+ TextBox5.Text+"' )",con);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        if(i>0)
        {
            Label6.Text = "Registered succesfully";
        }
        else
        {
            Label6.Text = "not registered successfully";
        }
    }
}