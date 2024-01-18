﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstproject
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Request.Browser.Cookies)
            {
                HttpCookie hc = new HttpCookie("Login");
                hc["uname"] = TextBox1.Text;
                hc["pw"] = TextBox2.Text;
                hc.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(hc);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Request.Browser.Cookies)
            {
                if(Request.Cookies["Login"]!=null)
                {
                    if(Request.Cookies["Login"]["uname"]!=null)
                    {
                        Label1.Text = Request.Cookies["Login"]["uname"];
                        Label2.Text = Request.Cookies["Login"]["pw"];
                    }
                }
            }
        }
    }
}