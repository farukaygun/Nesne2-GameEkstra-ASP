using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameEkstra
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("/SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //SERVER ADINI DEĞİŞTİR
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U8BS5U6\\SQLEXPRESS; Initial Catalog= forum; Integrated Security=True");
            conn.Open();
            SqlCommand komut = new SqlCommand("select mail from tblUser where mail='" + textBoxEmail.Text + "'", conn);
            SqlCommand komut2 = new SqlCommand("select password from tblKullanici where password='" + textBoxSifre.Text + "'", conn);
            SqlCommand kmt = new SqlCommand();           
            if (komut != null && komut2 != null)
            {
                Session.Timeout = 120;
                Session.Add("oturum", textBoxEmail.Text);
            }
            Response.Redirect("/HomePage.aspx");
            conn.Close();
        }
    }
}