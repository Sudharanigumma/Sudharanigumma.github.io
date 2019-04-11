using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Source : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie obj = new HttpCookie("Fnamen");
        obj.Value = TextBox1.Text;
        Response.Cookies.Add(obj);
        HttpCookie obj2 = new HttpCookie("Lnamen");
        obj2.Value = TextBox1.Text;
        Response.Cookies.Add(obj2);
        obj.Expires = DateTime.Now.AddDays(1);
        Response.Redirect("~/Target.aspx");

    }
}