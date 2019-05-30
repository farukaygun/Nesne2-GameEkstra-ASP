using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameEkstra
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            WCFKontrol.Service1Client client = new WCFKontrol.Service1Client();
            if (client.KrediKartiDogruMu(textBoxCCNo.Text.ToString()))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Ödeme", "alert('Ödeme Başarılı')", true);
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0TAUNLF; Initial Catalog=GameEkstraDatabase; Integrated Security=True");
                conn.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM tblSepet", conn);
                komut.ExecuteNonQuery();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Hata", "alert('Lütfen Kart Numaranızı Kontrol Ediniz')", true);
            }
        }
    }
}