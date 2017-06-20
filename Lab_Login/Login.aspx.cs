using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {   
        //check
        //if(string.IsNullOrEmpty(txtUserName.Text))
        if(txtUserName.Text.Trim() == "") {
            lblPrompt.Text = "Please keyin your name";
            return;
        }
        if(string.IsNullOrEmpty(txtPassword.Text)) {
            lblPrompt.Text = "Please keyin your password";
            return;
        }
        //Response.Cookies["userName"].Value = txtUserName.Text;
        //HttpCookie c = Request.Cookies["returnUrl"];

        //if (c == null) {
        //    Response.Redirect("Default.aspx");
        //} else {
        //    Response.Redirect("c.value");
        //}
        Session["UserName"] = txtUserName.Text;

        if (Session["userName"] == null) {
            Response.Redirect("Default.aspx");
        } else {
            Response.Redirect("secret.aspx");
        }
        
    }


    protected void Button1_Click(object sender, EventArgs e) {
      
    }
}