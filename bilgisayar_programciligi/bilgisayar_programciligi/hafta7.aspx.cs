using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void hesapla_Click(object sender, EventArgs e)
        {
            cikti.Text = baslangic_tarihi.SelectedDate.ToString("D")+ " ile "+ bitis_tarihi.SelectedDate.ToString("D") + " arasında "+ Convert.ToString(Math.Abs((bitis_tarihi.SelectedDate-baslangic_tarihi.SelectedDate).TotalDays)) +" gün bulunmaktadır.";
        }

        protected void bitis_tarihi_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsToday)
            {
                e.Cell.Text = "<a href=\"" + e.SelectUrl + "\" style=\"color:#000;\">Bugün</a>";

            }
        }

        protected void baslangic_tarihi_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsToday)
            {
                e.Cell.Text = "<a href=\""+e.SelectUrl+"\">Bugün</a>";

            }
              

        }
    }
}