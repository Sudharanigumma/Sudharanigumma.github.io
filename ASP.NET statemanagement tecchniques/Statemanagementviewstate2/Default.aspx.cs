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
        ViewState["Fname"] = Textbox1.Text;
        ViewState["Lname"] = Textbox2.Text;
        Label1.Text = "youe fname is:" + ViewState["Fname"];
        Label2.Text = "your  lname is:" + ViewState["Lname"];
            }
}