using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameEkstra
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //SERVER ADINI DEĞİŞTİR
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U8BS5U6\\SQLEXPRESS; Initial Catalog=forum; Integrated Security=True");
            conn.Open();
            SqlCommand kmt = new SqlCommand("Insert into  tblUsers VALUES  ('" + textBoxName.Text + "','" + textBoxSurname.Text + "','" + textBoxTCNo.Text + "','" + textBoxEmail.Text + "','" + textBoxPassword.Text + "','" + textBoxPhone.Text + "','" + textBoxAddress.Text + "')", conn);
            kmt.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("/Login.aspx");
        }
    }
}