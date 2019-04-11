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
        MultiView1.ActiveViewIndex= 0;
    }

    protected void ButtonN1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void ButtonL_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = MultiView1.Views.Count - 1;
    }

    protected void ButtonN2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void ButtonP1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }


    protected void ButtonF_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void ButtonP2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

}