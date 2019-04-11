using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie fcook = new HttpCookie("Lablefn");
        fcook.Value = TextBox1.Text;
        Response.Cookies.Add(fcook);

        HttpCookie lcook = new HttpCookie("Lableln");
        lcook.Value = TextBox2.Text;
        Response.Cookies.Add(lcook);

        Response.Redirect("~/Default2.aspx");
    }
}