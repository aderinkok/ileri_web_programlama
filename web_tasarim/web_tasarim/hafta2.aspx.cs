using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta2 : System.Web.UI.Page
    {
        static double sayi1,sayi2,sonuc;
        static string islem;
        protected void Ekleme(string sayi) {

            Hesap.Text = Hesap.Text + sayi;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Toplama_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Hesap.Text);
            islem = "+";
            Hesap.Text = "";
            cikti.Text = Convert.ToString(sayi1)+ islem;
        }

        protected void Esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(Hesap.Text);


            if (islem == "+") {
                sonuc= sayi1 + sayi2;
                Hesap.Text = Convert.ToString(sonuc);
            }
            if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
                Hesap.Text = Convert.ToString(sonuc);
            }
            if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                Hesap.Text = Convert.ToString(sonuc);
            }
            if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
                Hesap.Text = Convert.ToString(sonuc);
            }
            cikti.Text += Convert.ToString(sayi2);
            cikti.Text += "="+sonuc;



        }

        protected void Cikarma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Hesap.Text);
            islem = "-";
            Hesap.Text = "";
            cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Carpma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Hesap.Text);
            islem = "*";
            Hesap.Text = "";
            cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Bolme_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Hesap.Text);
            islem = "/";
            Hesap.Text = "";
            cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Sifir_Click(object sender, EventArgs e)
        {
            Ekleme("0");
          
        }

        protected void Bir_Click(object sender, EventArgs e)
        {
            Ekleme("1");
        }

        protected void Iki_Click(object sender, EventArgs e)
        {
            Ekleme("2");
        }

        protected void Uc_Click(object sender, EventArgs e)
        {
            Ekleme("3");
        }

        protected void Dort_Click(object sender, EventArgs e)
        {
            Ekleme("4");
        }

        protected void Bes_Click(object sender, EventArgs e)
        {
            Ekleme("5");
        }

        protected void Alti_Click(object sender, EventArgs e)
        {
            Ekleme("6");
        }

        protected void Yedi_Click(object sender, EventArgs e)
        {
            Ekleme("7");
        }

        protected void Sekiz_Click(object sender, EventArgs e)
        {
            Ekleme("8");
        }

        protected void Dokuz_Click(object sender, EventArgs e)
        {
            Ekleme("9");
        }

    }
}