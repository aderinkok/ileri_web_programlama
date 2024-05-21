using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void hesapla_Click(object sender, EventArgs e)
        {
            string baslangic, bitis;
       
            baslangic = baslangic_tarihi.SelectedDate.ToString("D");
            bitis = bitis_tarihi.SelectedDate.ToString("D");

            cikti.Text = baslangic+" ile "+bitis +" arasında "+ Convert.ToString(Math.Abs((bitis_tarihi.SelectedDate-baslangic_tarihi.SelectedDate).TotalDays))+" gün bulunmaktadır.";
        }

        protected void baslangic_tarihi_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsToday)
            {
                e.Cell.Text = "<a href=\""+ e.SelectUrl+"\">Bugün</a>";
            }
        }

        protected void bitis_tarihi_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsToday)
            {
                if (e.Day.IsToday)
                {
                    e.Cell.Text = "<a href=\"" + e.SelectUrl + "\" style=\"color:#000;\">Bugün</a>";
                }
            }

        }
    }
}