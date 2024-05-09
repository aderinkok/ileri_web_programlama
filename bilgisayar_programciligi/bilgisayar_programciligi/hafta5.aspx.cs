using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
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

            foreach (ListItem oge in lst_havuz.Items)
            {
                if (oge.Selected)
                {
                    silinecekler.Add(oge);
                }
            }
            
            if (silinecekler.Count<=5 && (silinecekler.Count+lst_secim.Items.Count)<=5) { 
            foreach (ListItem eleman in silinecekler)
            {
                lst_havuz.Items.Remove(eleman);
                lst_secim.Items.Add(eleman);
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

            foreach (ListItem oge in lst_secim.Items) {
                if (oge.Selected)
                {
                    silinecekler.Add(oge);
                }
            
            }

            foreach(ListItem eleman in silinecekler)
            {
                lst_secim.Items.Remove(eleman);
                lst_havuz.Items.Add(eleman);
            }

            lbl_havuz_bilgi.Text = "Listede " + lst_havuz.Items.Count + " öğe bulunmaktadır.";
            lbl_secim_bilgi.Text = "Listede " + lst_secim.Items.Count + " öğe bulunmaktadır.";
        }
    }
}