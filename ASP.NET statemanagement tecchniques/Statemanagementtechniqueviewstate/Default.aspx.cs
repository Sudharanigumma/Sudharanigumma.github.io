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
if(!IsPostBack)
        {
            ViewState["Count"] = 1;
            label1.Text = "Current values:" + ViewState["Count"];
            
        }
    }


    protected void button1_Click(object sender, EventArgs e)
    {
        int num =Convert.ToInt32( ViewState["Count"]);
        num++;
        ViewState["Count"] = num;
        label1.Text = "cutrent values is :" + ViewState["Count"];
    }
}