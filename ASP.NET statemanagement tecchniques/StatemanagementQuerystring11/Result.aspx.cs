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
        if (Request.QueryString["NAME"] != null&& Request.QueryString["ADDRESS"] != null)
        {
            Response.Write("<b>your fname is</b>" + Request.QueryString["NAME"].ToString());
            Response.Write("<br/>");
            Response.Write("<b>yourlname is</b>" + Request.QueryString["ADDRESS"].ToString());
        }
    }
}