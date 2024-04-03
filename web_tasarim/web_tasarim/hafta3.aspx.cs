using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Olustur_Click(object sender, EventArgs e)
        {
            int satirS, sutunS;
            Tablo1.BorderStyle = BorderStyle.Solid;
            Tablo1.BorderColor = Color.Black;
            /*
             Textbox'lara girilen değeri kontrol et.
            Eğer sayısal değer girilmemişse Label'da uyarı ver işleme devam etme.
             */
            satirS = Convert.ToInt16(SatirSayisi.Text);
            sutunS=Convert.ToInt16(SutunSayisi.Text);

            /*
             && ve
             || veya
             
             */
            if(satirS > 20 || sutunS >20)
            {
                Bilgi.Text = "Satır sayısı veya sütun sayısı 20'den büyük olamaz.";
            }
            else
            {
                Bilgi.Text = "";

                for(int i = 1; i <= satirS; i++)
                {
                    // Nesne tanımlaması
                    // SinifAdi nesneAdi = new SinifAdi();
                    TableRow tSatir = new TableRow();

                    Tablo1.Controls.Add(tSatir);
                    for(int j = 0; j < sutunS; j++)
                    {
                        TableCell hucre = new TableCell();
                        hucre.Text = "R-"+i+" / "+"C-"+(j+1);
                        hucre.BorderColor = Color.Black;
                        hucre.BorderStyle = BorderStyle.Solid;
                        hucre.BorderWidth = 1;
                        tSatir.Controls.Add(hucre);

                    }


                }
            }



        }
    }
}