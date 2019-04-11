using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    SqlCommand cmd;
    int EID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7");
        da = new SqlDataAdapter("SELECT *FROM EMP", con);
        da.Fill(ds, "EMP");
        if (!IsPostBack)
        {
            if (EID < ds.Tables[0].Rows.Count)
            {
                TextBox1.Text = ds.Tables[0].Rows[EID][0].ToString();
                TextBox2.Text = ds.Tables[0].Rows[EID][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[EID][2].ToString();
            }
            else
            {
                Label4.Text = "data is completed";

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EID++;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7");
        da = new SqlDataAdapter("SELECT *FROM EMP", con);
        da.Fill(ds, "EMP");
        int previous = ds.Tables[0].Rows.Count;
        DataRow dr = ds.Tables[0].NewRow();
        dr[0] = TextBox1.Text;
        dr[1] = TextBox2.Text;
        dr[2] = TextBox3.Text;
        ds.Tables[0].Rows.Add(dr);
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds, "EMP");
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
        int present = ds.Tables[0].Rows.Count;
        if(present>previous)
        {
            Label4.Text = "record is inserted";
        }
        else
        {
            Label4.Text = "record is not inserted";
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
       
        int previous = Convert.ToInt32(ds.Tables[0].Rows[EID][2]);
        ds.Tables[0].Rows[EID][2] = TextBox1.Text;
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds,"EMP");
        TextBox1.Text = " ";
        int present = Convert.ToInt32(ds.Tables[0].Rows[EID][2]);
        if (present != previous)
        {
            Label4.Text = "price updated";
        }
        else
        {
            Label4.Text = "price not updated";
        }
    }
}