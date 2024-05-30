using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            lbl_ad.Text = txt_ad.Text;
            lbl_soyad.Text = txt_soyad.Text;

            if (mezuniyet1.Checked)
            {
                lbl_mezuniyet.Text = mezuniyet1.Text;
            }
            if (mezuniyet2.Checked)
            {
                lbl_mezuniyet.Text = mezuniyet2.Text;
            }
            if (mezuniyet3.Checked)
            {
                lbl_mezuniyet.Text = mezuniyet3.Text;
            }
            if (mezuniyet4.Checked)
            {
                lbl_mezuniyet.Text = mezuniyet4.Text;
            }
            if (cinsiyet.SelectedItem != null)
            {
                lbl_cinsiyet.Text = cinsiyet.SelectedItem.Text;
            }

            lbl_dil_bilgisayar.Text = "";
            if (dil1.Checked)
            {
                lbl_dil_bilgisayar.Text += dil1.Text;
            }

            if (dil2.Checked)
            {
                if(lbl_dil_bilgisayar.Text!="")
                {
                    lbl_dil_bilgisayar.Text += ", ";
                }

                lbl_dil_bilgisayar.Text += dil2.Text;
            }
            if (dil3.Checked)
            {
                if (lbl_dil_bilgisayar.Text != "")
                {
                    lbl_dil_bilgisayar.Text += ", ";
                }

                lbl_dil_bilgisayar.Text += dil3.Text;
            }
            if (dil4.Checked)
            {
                if (lbl_dil_bilgisayar.Text != "")
                {
                    lbl_dil_bilgisayar.Text += ", ";
                }

                lbl_dil_bilgisayar.Text += dil4.Text;
            }
            if (dil5.Checked)
            {
                if (lbl_dil_bilgisayar.Text != "")
                {
                    lbl_dil_bilgisayar.Text += ", ";
                }

                lbl_dil_bilgisayar.Text += dil5.Text;
            }

            lbl_yabanci_diller.Text = "";
            for (int i=0;i<= yabanciDil.Items.Count-1; i++)
            {
                if (yabanciDil.Items[i].Selected)
                {
                    if (lbl_yabanci_diller.Text != "")
                    {
                        lbl_yabanci_diller.Text += ", ";
                    }
                    lbl_yabanci_diller.Text += yabanciDil.Items[i].Text;
                    
                    
                }
            }


        }
    }
}