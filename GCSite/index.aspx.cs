using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriKatmani;

namespace GCSite
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Oturum.ID;
            string Nick = Oturum.Nick;
            string Mail = Oturum.Mail;


            if (string.IsNullOrEmpty(Nick) )
            {
                kayitBtn.Visible = true;
                girisBtn.Visible = true;
                cikisBtn.Visible = false;
                lblNick.Visible = false;
            }
            else
            {
                kayitBtn.Visible = false;
                girisBtn.Visible = false;
                cikisBtn.Visible = true;
                lblNick.Text = Nick;
                lblNick.Visible = true;
            }
        }

        protected void kayitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void girisBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void cikisBtn_Click(object sender, EventArgs e)
        {
            Oturum.CikisYap();
            Response.Redirect("Index.aspx");
        }
    }
}