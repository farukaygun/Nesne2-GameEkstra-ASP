using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GameEkstra
{
    public partial class HomePage : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        { 
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
            conn.Open();
            if (Session["oturum"] == null)
            {
                btnMyCart.Visible = false;
                btnCikis.Visible = false;
                btnLogin.Visible = true;
                SqlCommand komut = new SqlCommand("DELETE FROM tblSepet", conn);
                komut.ExecuteNonQuery();
            }
            if (Session["oturum"] != null)
            {
                btnMyCart.Visible = true;
                btnCikis.Visible = true;
                btnLogin.Visible = false;
            }
            String SQL = "SELECT * FROM tblProduct"; 
            SqlDataAdapter Adpt = new SqlDataAdapter(SQL, conn);
            DataSet login = new DataSet();
            Adpt.Fill(login);
            for (int i = 1; i < 6; i++)
            {
                if (i == 1)
                {
                    Label1.Text = login.Tables[0].Rows[0]["name"].ToString();
                    Label2.Text = login.Tables[0].Rows[0]["price"].ToString();
                }
                if (i == 2)
                {
                    Label3.Text = login.Tables[0].Rows[1]["name"].ToString();
                    Label4.Text = login.Tables[0].Rows[1]["price"].ToString();
                }
                if (i == 3)
                {
                    Label5.Text = login.Tables[0].Rows[2]["name"].ToString();
                    Label6.Text = login.Tables[0].Rows[2]["price"].ToString();
                }
                if (i == 4)
                {
                    Label7.Text = login.Tables[0].Rows[3]["name"].ToString() ;
                    Label8.Text = login.Tables[0].Rows[3]["price"].ToString();
                }
                if (i == 5)
                {
                    Label9.Text = login.Tables[0].Rows[4]["name"].ToString();
                    Label10.Text = login.Tables[0].Rows[4]["price"].ToString();
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        protected void btnMyCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Cart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["oturum"] == null)
            {
                Response.Redirect("/Login.aspx");
            }else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  tblSepet VALUES  ('" + Label1.Text + "','" + float.Parse(Label2.Text) + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("/Cart.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["oturum"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  tblSepet VALUES  ('" + Label3.Text + "','" + float.Parse(Label4.Text) + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("/Cart.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["oturum"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  tblSepet VALUES  ('" + Label5.Text + "','" + float.Parse(Label6.Text) + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("/Cart.aspx");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["oturum"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  tblSepet VALUES  ('" + Label7.Text + "','" + float.Parse(Label8.Text) + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("/Cart.aspx");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Session["oturum"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand kmt = new SqlCommand("Insert into  tblSepet VALUES  ('" + Label9.Text + "','" + float.Parse(Label10.Text) + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("/Cart.aspx");
            }
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/HomePage.aspx");
        }
    }
}