using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public TextBox txtFName
    {
        get
        {
            return _txtF;
        }
    }
    public TextBox txtLName
    {
        get
        {
            return _txtL;
        }
    }
}