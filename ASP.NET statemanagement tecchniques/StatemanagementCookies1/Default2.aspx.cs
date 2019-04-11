using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.Cookies["Lablefn"] !=null && Request.Cookies["Lableln"] != null)
        {
            Response.Write("<b>your fname is:</b>" + Request.Cookies["Lablefn"].Value);
            Response.Write("<br/>");
            Response.Write("<b>your lname is:</b>" + Request.Cookies["Lableln"].Value);
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}