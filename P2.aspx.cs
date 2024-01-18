using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject
{
    public partial class P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["na"];
            Label2.Text = Request.QueryString["ag"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = Application["na"].ToString();
            Label4.Text = Session["ag"].ToString();
        }
    }
}