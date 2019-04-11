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
        HttpCookie obj = new HttpCookie("Fcook");
        obj.Values["Fnamen"] = TextBox1.Text;
        obj.Values["Lnamen"] = TextBox2.Text;
        obj.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(obj);

        HttpCookie obj1 = new HttpCookie("Lcook");
        obj1.Values["Usnn"] = TextBox1.Text;
        obj1.Values["Pwdn"] = TextBox2.Text;
        obj1.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(obj1);

        HttpCookie obj2 = new HttpCookie("Acook");
        obj2.Value = TextBox5.Text;
       Response.Cookies.Add(obj2);
        Response.Redirect("~/Result.aspx");
    }
}