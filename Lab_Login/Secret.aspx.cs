﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secret : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //HttpCookie c = Request.Cookies["userName"];
        //if ( == null) {
        //    Response.Redirect("Login.aspx");
        //    return;
        //}
        if (Session["userName"] == null) {
            Response.Redirect("Default.aspx");
        }
    }
}