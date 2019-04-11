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
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7;");
        da = new SqlDataAdapter("select * from PRODUCTS", con);
        da.Fill(ds, "PRODUCTS");
        if (!IsPostBack)
        {
            DropDownList1.DataSource = ds.Tables["PRODUCTS"];
            DropDownList1.DataTextField = ds.Tables["PRODUCTS"].Columns["PNO"].ToString();
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = ds.Tables[0].Rows[DropDownList1.SelectedIndex][1].ToString();
        TextBox2.Text = ds.Tables[0].Rows[DropDownList1.SelectedIndex][2].ToString();
    }
}