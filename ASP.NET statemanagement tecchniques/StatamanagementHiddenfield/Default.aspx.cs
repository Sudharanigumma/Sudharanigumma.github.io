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
            Hidden1.Value = "1";
            Labele.Text = "curent value is:" + Hidden1.Value;


        }
    }

    protected void button1_Click(object sender, EventArgs e)
    {
        int num = int.Parse(Hidden1.Value);
        num++;
        Hidden1.Value = num.ToString();
        Labele.Text = "current value is:" + Hidden1.Value;
    }
}