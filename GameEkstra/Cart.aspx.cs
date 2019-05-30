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
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                String SQL = "SELECT * FROM tblSepet";
                SqlDataAdapter Adpt = new SqlDataAdapter(SQL, conn);
                DataSet login = new DataSet();
                String TPLM = "SELECT SUM(price) as price FROM tblSepet";
                SqlDataAdapter Adpt2 = new SqlDataAdapter(TPLM, conn);
                DataSet login2 = new DataSet();
                Adpt2.Fill(login2);
                if (login2.Tables[0].Rows.Count != 0)
                {
                    Label2.Visible = true;
                    Label2.Text = login2.Tables[0].Rows[0]["price"].ToString();
                }
                else
                {
                    Label2.Visible = false;
                }
            }
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Payment.aspx");
        }

        protected void btnTemizle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
            conn.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM tblSepet", conn);
            komut.ExecuteNonQuery();
            Response.Redirect("/Cart.aspx");
        }
    }
}