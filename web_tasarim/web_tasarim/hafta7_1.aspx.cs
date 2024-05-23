using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta7_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex == 0)
            {
                btn_geri.Visible = false;
                btn_ileri.Visible = true;
            }else if (MultiView1.ActiveViewIndex > 0)
            {
                btn_geri.Visible = true;
                btn_ileri.Visible = true;  
            }
            
            if(MultiView1.ActiveViewIndex == MultiView1.Views.Count - 1)
            {
                btn_geri.Visible = true;
                btn_ileri.Visible = false;
            }

        }

        protected void kaydet_Click(object sender, EventArgs e)
        {

        }

        protected void btn_geri_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex!=0)
            {
                MultiView1.ActiveViewIndex = MultiView1.ActiveViewIndex -1;
            }
        }

        protected void btn_ileri_Click(object sender, EventArgs e)
        {
            if(MultiView1.Views.Count-1 != MultiView1.ActiveViewIndex)
            {
                MultiView1.ActiveViewIndex = MultiView1.ActiveViewIndex + 1;
            }
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex == 0)
            {
                btn_geri.Visible = false;
                btn_ileri.Visible = true;
            }
            else if (MultiView1.ActiveViewIndex > 0)
            {
                btn_geri.Visible = true;
                btn_ileri.Visible = true;
            }
            
            if (MultiView1.ActiveViewIndex == MultiView1.Views.Count - 1)
            {
                btn_geri.Visible = true;
                btn_ileri.Visible = false;
            }

        }
    }
}