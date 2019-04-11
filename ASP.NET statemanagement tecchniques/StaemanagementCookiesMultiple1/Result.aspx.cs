using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(Request.Cookies["Fcook"]!=null&& Request.Cookies["Lcook"] != null&& Request.Cookies["Acook"] != null)
        {
            Response.Write("<b>Your fname is:</b>" + Request.Cookies["Fcook"]["Fnamen"].ToString());
            Response.Write("<br/>");
            Response.Write("<b>Your lname is:</b>" + Request.Cookies["Fcook"]["Lnamen"].ToString());
            Response.Write("<br/>");
            Response.Write("<b>Your usn is:</b>" + Request.Cookies["Lcook"]["Usnn"].ToString());
            Response.Write("<br/>");
            Response.Write("<b>Your pwd is:</b>" + Request.Cookies["Lcook"]["Pwdn"].ToString());
            Response.Write("<br/>");
            Response.Write("<b>Your Adress is:</b>" + Request.Cookies["Acook"].Value);
        }
    }
}