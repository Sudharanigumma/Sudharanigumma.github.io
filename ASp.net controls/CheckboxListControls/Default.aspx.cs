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
        string stringopt = string.Empty;
        foreach(ListItem li in CheckBoxList1.Items)
        {
            if (li.Selected == true)
            {
                stringopt += li.Text + " ,";
            }
                Label2.Text = "<b>your selected items are:" + stringopt;
            }
        }
    }
