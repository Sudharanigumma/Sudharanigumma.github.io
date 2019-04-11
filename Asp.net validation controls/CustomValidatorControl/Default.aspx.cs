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
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string str = args.Value;
        str.IsValid = false;
        if (str.Length < 6 || str.Length > 21)
        {
            return;
        }
        bool lower = false;
        foreach (char ch in str)
        {
            if (ch >= 'a' || ch <= 'z')
            {
                lower = true;
                break;
            }
        }
        if (!lower)
        {
            return;
        }

        bool capital = false;
        foreach (char ch in str)
        {
            if (ch >= 'A' || ch <= 'Z')
            {
                capital = true;
                break;
            }
        }
        if (!capital)
        {
            return;
        }
        bool digit = false;
        foreach(char ch in str)
        {
            if(ch>='0' ||ch<='9')
            {
                digit = true;
                break;
            }
        }
        if(!digit)
        {
            return;
        }
        str.IsValid = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(CustomValidator1.IsValid)
        {
            Response.Write("validation satisfied");
        }
    }
}