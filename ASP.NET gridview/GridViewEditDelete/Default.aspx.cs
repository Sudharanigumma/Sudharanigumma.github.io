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
    protected void Page_Load(object sender, EventArgs e)
    {
      if(!IsPostBack)
        {
            BindEmp();
        }
    }
    public void BindEmp()
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        da = new SqlDataAdapter("select * from EMP", con);
        da.Fill(ds, "EMP");
        Geditdel.DataSource = ds.Tables["EMP"];
        Geditdel.DataBind();
    }


    protected void Geditdel_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Geditdel.EditIndex = e.NewEditIndex;
        BindEmp();
    }

    protected void Geditdel_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Geditdel.EditIndex = -1;
        BindEmp();
    }

    protected void Geditdel_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        con.Open();
        GridViewRow row = Geditdel.Rows[e.RowIndex];
        Label labeno = (Label)row.FindControl("labeno");
        TextBox txtsal = (TextBox)row.FindControl("txtsal");
        cmd = new SqlCommand("UPDATE EMP SET SALARY=" + txtsal.Text + " WHERE EID =" + labeno.Text + " ", con);
        int i = cmd.ExecuteNonQuery();
        Geditdel.EditIndex = -1;
        if(i>0)
        {
            Label1.Text = "salary updated";
        }
        else
        {
            Label1.Text = "salary is not updated";
        }
    }

    protected void Geditdel_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        con.Open();
        GridViewRow row = Geditdel.Rows[e.RowIndex];
        Label labeno = (Label)row.FindControl("labeno");
        cmd = new SqlCommand("DELETE FROM EMP WHERE EID=" + labeno.Text + " ", con);
        int i = cmd.ExecuteNonQuery();
        if(i>0)
        {
            Label1.Text = "record is deleted";
            BindEmp();
        }
        else
        {
            Label1.Text = "record is not deleted";
        }
    }
}