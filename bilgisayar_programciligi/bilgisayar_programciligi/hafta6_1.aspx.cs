using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta6_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {

        }

        protected void drp_cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(drp_cinsiyet.SelectedValue) == 1)
            {
                askerlikPanel.Visible = true;

            }
            else
            {
                askerlikPanel.Visible = false;
            }
        }

        protected void drp_kvkk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(drp_kvkk.SelectedValue) == 1)
            {
                btn_kaydet.Enabled = true;
            }
            else
            {
                btn_kaydet.Enabled=false;
            }
        }
    }
}