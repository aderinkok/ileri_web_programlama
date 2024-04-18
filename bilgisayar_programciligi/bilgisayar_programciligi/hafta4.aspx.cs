using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  cikti.Text = "Örnek";

            //Response.Write("Çıktı");

               
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text != "")
            {
                liste.Items.Add(txt_isim.Text);
                txt_isim.Text = "";
            }
            
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            liste.Items.Remove(liste.SelectedItem);
        }
    }
}