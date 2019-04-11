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
    int PNO = 0;


  protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection("Server=.;Integrated Security=SSPI;Database=ASPNET7");
        da = new SqlDataAdapter("SELECT *FROM PRODUCTS", con);
        da.Fill(ds, "PRODUCTS");
        if (!IsPostBack)
        {
            if (PNO < ds.Tables[0].Rows.Count)
            {
                TextBox1.Text = ds.Tables[0].Rows[PNO][0].ToString();
                TextBox2.Text = ds.Tables[0].Rows[PNO][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[PNO][2].ToString();
            }
            else
            {
                Label4.Text = "data is completed";

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PNO++;
    }
}