using System;
using System.Collections;
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
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
            SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
            conn.Open();
            conn2.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn2;
            cmd.CommandText = "SELECT mail FROM tblUser";
            cmd2.CommandText = "SELECT sifre FROM tblUser";
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            ArrayList Mailler = new ArrayList();
            ArrayList Sifreler = new ArrayList();
            while (dr.Read())
            {
                Mailler.Add(dr["mail"]);
            }
            while (dr2.Read())
            {
                Sifreler.Add(dr2["sifre"]);
            }
            foreach (string item in Mailler)
            {
                if (item == textBoxEmail.Text)
                {
                    foreach(string sifre in Sifreler)
                    {
                        if(sifre == textBoxSifre.Text)
                        {
                            Session.Timeout = 120;
                            Session.Add("oturum", textBoxEmail.Text);
                            Response.Redirect("/HomePage.aspx");
                        }
                        else
                        {
                            Response.Redirect("/Login.aspx");
                        }
                    }
                }
                else
                {
                    Response.Redirect("/Login.aspx");
                }
            }

           /* if (dr != null && komut2 != null)
            {
                Session.Timeout = 120;
                Session.Add("oturum", textBoxEmail.Text);
                Response.Redirect("/HomePage.aspx");
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
            conn.Close();*/
        }
    }
}