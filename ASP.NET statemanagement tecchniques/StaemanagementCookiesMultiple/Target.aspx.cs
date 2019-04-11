using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Target : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(Request.Cookies["Fnamen"] !=null&& Request.Cookies["Lnamen"] !=null)
        {
            Response.Write( "<b>WELCOME</b>"+ Request.Cookies["Fnamen"].Value);
        }
else
        {
            Response.Redirect("~/Source.aspx");
        }
    }
}