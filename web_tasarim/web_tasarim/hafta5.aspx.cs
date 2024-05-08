using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_havuz_bilgi.Text = "Listede " + lst_havuz.Items.Count + " öğe bulunmaktadır.";
            lbl_secim_bilgi.Text = "Listede " + lst_secim.Items.Count + " öğe bulunmaktadır.";
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            // SınıfAdı nesneAdı = new SınıfAdı();
            List<ListItem> silinecekler = new List<ListItem>();
            
            foreach (ListItem silinecek in lst_havuz.Items)
            {
                if (silinecek.Selected) {
                silinecekler.Add(silinecek);
                
                }
            }

            if (silinecekler.Count<=5 && (lst_secim.Items.Count+silinecekler.Count)<=5)
            {
                lbl_bilgi.Text = "";
                foreach (ListItem eklenecek in silinecekler)
                {
                    lst_havuz.Items.Remove(eklenecek);
                    lst_secim.Items.Add(eklenecek);
                }
            }
            else
            {
                lbl_bilgi.Text = "En fazla 5 şehir seçebilirsiniz.";
            }

            lbl_havuz_bilgi.Text = "Listede " + lst_havuz.Items.Count + " öğe bulunmaktadır.";
            lbl_secim_bilgi.Text = "Listede " + lst_secim.Items.Count + " öğe bulunmaktadır.";


        }

        protected void btn_cikar_Click(object sender, EventArgs e)
        {
            List<ListItem> silinecekler = new List<ListItem>();

            foreach (ListItem oge in lst_secim.Items)
            {
                if (oge.Selected)
                {
                    silinecekler.Add(oge);
                }
            }
            foreach (ListItem sil in silinecekler)
            {
                lst_secim.Items.Remove(sil);
                lst_havuz.Items.Add(sil);
            }
            lbl_havuz_bilgi.Text = "Listede " + lst_havuz.Items.Count + " öğe bulunmaktadır.";
            lbl_secim_bilgi.Text = "Listede " + lst_secim.Items.Count + " öğe bulunmaktadır.";
        }
    }
}