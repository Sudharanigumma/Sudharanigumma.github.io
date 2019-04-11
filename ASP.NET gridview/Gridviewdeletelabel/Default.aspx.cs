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
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
     if(!IsPostBack)
        {
            BindEMP();
        }
    }
    public void BindEMP()
    {
      con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        da = new SqlDataAdapter("select * from EMP", con);
        da.Fill(ds, "EMP");
        Gridemp.DataSource = ds.Tables["EMP"];
        Gridemp.DataBind();
    }

    protected void Gridemp_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        con.Open();
        GridViewRow row = Gridemp.Rows[e.RowIndex];
        Label labeleid = (Label)row.FindControl("labeleid");
        cmd = new SqlCommand("delete from emp where eid=" + labeleid.Text + " ", con);
        int i = cmd.ExecuteNonQuery();
        if(i>0)
        {
            Label1.Text = "record deleted";
            BindEMP();
        }   
        else
        {
            Label1.Text = "record is not deleted";
        }
        con.Close();
            }
   
}
