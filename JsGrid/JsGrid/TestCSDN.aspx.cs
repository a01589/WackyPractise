using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsGrid
{
    public partial class TestCSDN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "单号1,单号2";
            string[] m = s.Split();
            lbl.Text = m[0];
        }
    }
}