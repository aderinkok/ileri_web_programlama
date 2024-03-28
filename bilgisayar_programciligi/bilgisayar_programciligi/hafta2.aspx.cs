using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta2 : System.Web.UI.Page
    {
        static double sayi1, sayi2, sonuc;
        static string islem;
        protected void Ekleme(string sayi)
        {
            /*
             Islem.Text = Islem.Text + "0";
             */
            Islem.Text += sayi;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sifir_Click(object sender, EventArgs e)
        {

            Ekleme("0");
        }

        protected void Esittir_Click(object sender, EventArgs e)
        {

            sayi2 = Convert.ToDouble(Islem.Text);
            Islem.Text = "";

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;

            }
            if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            Islem.Text = Convert.ToString(sonuc);
            Cikti.Text += Convert.ToString(sayi2) + "=" + Convert.ToString(sonuc);

        }

        protected void Toplama_Click(object sender, EventArgs e)
        {

            sayi1 = Convert.ToDouble(Islem.Text);
            islem = "+";
            Cikti.Text = Convert.ToString(sayi1) + islem;
            Islem.Text = "";


        }

        protected void Cikarma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Islem.Text);
            islem = "-";
            Islem.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Uc_Click(object sender, EventArgs e)
        {
            Ekleme("3");
        }

        protected void Iki_Click(object sender, EventArgs e)
        {
            Ekleme("2");
        }

        protected void Bir_Click(object sender, EventArgs e)
        {
            Ekleme("1");
        }

        protected void Carpma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Islem.Text);
            islem = "*";
            Islem.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
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

        protected void Bolme_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(Islem.Text);
            islem = "/";
            Islem.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
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
    }
}