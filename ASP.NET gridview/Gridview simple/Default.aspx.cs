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
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        Con = new SqlConnection("Server =.; Integrated Security = SSPI; Database = ASPNET7; ");
        da = new SqlDataAdapter("SELECT * FROM EMP", Con);
        da.Fill(ds, "EMP");
        GridView1.DataSource = ds.Tables["EMP"];
        GridView1.DataBind();
           
    }
}