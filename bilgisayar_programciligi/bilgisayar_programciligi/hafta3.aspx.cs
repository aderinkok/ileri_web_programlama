using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void olustur_Click(object sender, EventArgs e)
        {
            Tablo.BorderStyle = BorderStyle.Solid;
            Tablo.BorderColor = Color.Black;
            int satirS, sutunS;
            /*
             Textbox'lara girilen değerlerin sadece sayısal olanlarını kabul et.
            Eğer harf veya sembol gibi sayısal olmayan karakterler girilirse yalnızcasayısal değer giriniz hatası versin.

             
             */

            satirS = Convert.ToInt16(satirSayisi.Text);
            sutunS = Convert.ToInt16(sutunSayisi.Text);

            if (satirS > 20  || sutunS > 20)
            {
                Bilgi.Text = "Satır ve Sütun Sayısı 20'den büyük olamaz.";
            }
            else
            {
                for (int i = 1; i <= satirS; i++)
                {
                    TableRow row = new TableRow();
                    Tablo.Controls.Add(row);

                    for (int j = 0; j < sutunS; j++)
                    {
                        TableCell hucre = new TableCell();
                        hucre.Text = "R -"+i+" / "+"C -"+ (j+1);
                        hucre.BorderStyle = BorderStyle.Solid;
                        hucre.BorderColor = Color.Black;
                        hucre.BorderWidth = 1;
                        row.Controls.Add(hucre);

                    }

                }

            }
           







        }
    }
}