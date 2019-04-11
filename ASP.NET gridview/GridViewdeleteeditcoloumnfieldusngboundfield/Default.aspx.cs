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
    SqlDataReader dr;
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

            if (!IsPostBack)
            {
                BindEmp();
            }
        }
    }
    public void BindEmp()
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        da = new SqlDataAdapter("select * from EMP", con);
        da.Fill(ds, "EMP");
        GridEmp.DataSource = ds.Tables["EMP"];
        GridEmp.DataBind();
    }

    protected void GridEmp_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridEmp.EditIndex = e.NewEditIndex;
        BindEmp();
    }

    protected void GridEmp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridEmp.EditIndex = -1;
        BindEmp();
    }

    protected void GridEmp_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        con.Open();
        GridViewRow row = GridEmp.Rows[e.RowIndex];
        Label Label1 = (Label)row.FindControl("Label1");
        TextBox TextBox3 = (TextBox)row.FindControl("TextBox3");
        cmd = new SqlCommand("UPDATE EMP SET SALARY=" + TextBox3.Text + " WHERE EID =" + Label1.Text + " ", con);
        int i = cmd.ExecuteNonQuery();
        GridEmp.EditIndex = -1;
        if (i > 0)
        {
            Label4.Text = "salary updated";
        }
        else
        {
            Label4.Text = "salary is not updated";
        }
    }

    protected void GridEmp_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        con.Open();
        GridViewRow row = GridEmp.Rows[e.RowIndex];
        Label Label1 = (Label)row.FindControl("Label1");
        cmd = new SqlCommand("DELETE FROM EMP WHERE EID=" + Label1.Text + " ", con);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Label4.Text = "record is deleted";
            BindEmp();
        }
        else
        {
            Label4.Text = "record is not deleted";
        }
    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        EID++;
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
        if (present > previous)
        {
            Label4.Text = "record is inserted";
        }
        else
        {
            Label4.Text = "record is not inserted";
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        TextBox3.Text = " ";
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7");
        cmd = new SqlCommand("UPDATE EMP SET SALARY=" + TextBox3.Text + "WHERE EID=" + TextBox1.Text);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = " ";
        if(i>0)
        {
            Label4.Text = "salary is updated";
}
        else
        {
            Label4.Text = "salary is not updated";
 }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("DELETE FROM EMP WHERE EID=" + TextBox1.Text);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = " ";
        if (i > 0)
        {
            Label4.Text = "salary is updated";
        }
        else
        {
            Label4.Text = "salary is not updated";
        }
    }
}
