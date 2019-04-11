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
        if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
        {
            TextBox txtF= (TextBox)PreviousPage.FindControl("txtFN");
            TextBox txtL= (TextBox)PreviousPage.FindControl("txtLN");
            Response.Write("your fname is :"+txtF.Text.Trim());
            Response.Write("your lname is:"+txtL.Text.Trim());
        }
        else
        {
            Response.Redirect("~/Source.aspx");
        }

    }
}