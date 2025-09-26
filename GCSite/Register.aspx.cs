using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using VeriKatmani;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace GCSite
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Basit bir email regex kontrolü
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string Nick = tbNick.Text;
            string Mail = tbMail.Text;
            string Pasword = tbPassword.Text;


            DataModel dataModel = new DataModel();

            if (string.IsNullOrEmpty(Nick) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Pasword)) {
                registerMesaj.Text = "Boş Bırakılmaz.";
                registerMesaj.Visible = true;
                return;
            }

            if (Nick.Length > 40)
            {
                registerMesaj.Text = "Nick 40 Karakter Uzunluğunda Sınırlı.";
                registerMesaj.Visible = true;
                return;
            }

            if (dataModel.NickIsHaveOther(Nick))
            {
                registerMesaj.Text = "Aynı Nicke Sahip Başka Biri Var. Farklı Nick Deneyiniz.";
                registerMesaj.Visible = true;
                return;
            }

            if (!IsValidEmail(Mail))
            {
                registerMesaj.Text = "Hatalı Mail.";
                registerMesaj.Visible = true;
                return;
            }

            if (dataModel.MailIsHaveOther(Mail))
            {
                registerMesaj.Text = "Bu Mail Kullanılmış.";
                registerMesaj.Visible = true;
                return;
            }

            if (Pasword.Length > 20)
            {
                registerMesaj.Text = "Şifre 20 Karakter Uzunluğunda Sınırlı.";
                registerMesaj.Visible = true;
                return;
            }
            
            if (dataModel.AddNewMember(Nick, Mail, Pasword))
            {
                registerMesaj.BackColor = System.Drawing.Color.Green;
                registerMesaj.Text = "Kayıt Olma İşlemi Başarılı Giriş Sekmesine Yönlendiriyorsunuz..";
                registerMesaj.Visible = true;

                Response.AddHeader("REFRESH", "3;URL=Login.aspx");
                return;
            }else
            {
                registerMesaj.BackColor = System.Drawing.Color.Red;
                registerMesaj.Text = "Başarısız İşlem Lütfen Tekrar Deneyiniz.";
                registerMesaj.Visible = true;
            }

        }
    }
}