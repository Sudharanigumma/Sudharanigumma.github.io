﻿using System;
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




    protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
    {
        Response.Write("your selected:" + BulletedList1.Items[e.Index].Text);
    }

   
}