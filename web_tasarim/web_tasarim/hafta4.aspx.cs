using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Test");

           // Button2.Enabled = false;
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_metin.Text !="")
            {
                liste.Items.Add(txt_metin.Text);
                txt_metin.Text = "";
            }
            

        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            liste.Items.Remove(liste.SelectedItem);
        }
    }
}