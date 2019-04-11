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
    SqlConnection Con;
    SqlDataAdapter da;
    SqlCommand cmd;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEmp();
        }
    }
    public void BindEmp()
    {
        Con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        da = new SqlDataAdapter("select * from EMP", Con);
        da.Fill(ds, "EMP");
        Gridproduct.DataSource = ds.Tables["EMP"];
        Gridproduct.DataBind();
    }


    protected void Gridproduct_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Gridproduct.EditIndex = e.NewEditIndex;
        BindEmp();
}


    protected void Gridproduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Gridproduct.EditIndex = -1;
        BindEmp();
    }

    protected void Gridproduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        Con.Open();
        GridViewRow row = Gridproduct.Rows[e.RowIndex];
        Label Labeleid = (Label)row.FindControl("Labeleid");
        TextBox texno = (TextBox)row.FindControl("texno");
        cmd = new SqlCommand("UPDATE EMP SET SALARY=" + texno.Text + " WHRER EID=" + Labeleid.Text + " ", Con);
        int i = cmd.ExecuteNonQuery();
        Gridproduct.EditIndex = -1;
        if(i>0)
        {
            Label1.Text = "salary is updated";
            BindEmp();
        }
        else
        {
            Label1.Text = "salary is not updated";
        }
    }
}