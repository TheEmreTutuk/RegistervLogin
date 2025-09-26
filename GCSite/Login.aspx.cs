using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriKatmani;

namespace GCSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string Nick = tbNick.Text;
            string Pasword = tbPassword.Text;

            DataModel dataModel = new DataModel();

            if (string.IsNullOrEmpty(Nick) || string.IsNullOrEmpty(Pasword))
            {
                loginMesaj.Text = "Boş Bırakılmaz.";
                loginMesaj.Visible = true;
                return;
            }

            if (Nick.Length > 40)
            {
                loginMesaj.Text = "Nick 40 Karakter Uzunluğunda Sınırlı.";
                loginMesaj.Visible = true;
                return;
            }

            if (Pasword.Length > 20)
            {
                loginMesaj.Text = "Şifre 20 Karakter Uzunluğunda Sınırlı.";
                loginMesaj.Visible = true;
                return;
            }

            if (dataModel.LoginMember(Nick,Pasword))
            {
                loginMesaj.BackColor = System.Drawing.Color.Green;
                loginMesaj.Text = "Giriş İşlemi Başarılı Ana Sekmesine Yönlendiriyorsunuz..";
                loginMesaj.Visible = true;

                Response.AddHeader("REFRESH", "2;URL=index.aspx");
                return;
            }
            else
            {
                loginMesaj.BackColor = System.Drawing.Color.Red;
                loginMesaj.Text = "Nick ve Şifreniz Yanlış. Tekrar Deneyiniz.";
                loginMesaj.Visible = true;
            }
        }
    }
}