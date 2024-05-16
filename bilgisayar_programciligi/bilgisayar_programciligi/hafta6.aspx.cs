using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         if(!IsPostBack) {

                List<ListItem> iller = new List<ListItem>() {
            new ListItem("Bilecik","11"),
            new ListItem("Bursa","16"),
            new ListItem("Malatya","44")

            };

                foreach (ListItem oge in iller)
                {
                    drp_il.Items.Add(oge);
                }

            }

           
        }

        protected void drp_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListItem> ilceler = new List<ListItem>();
            ilceler.Clear();
            drp_ilce.Items.Clear();
            if (drp_il.SelectedValue == "11")
            {
                ilceler.AddRange(new List<ListItem>() { 
                new ListItem("Merkez","1"),
                new ListItem("Pazaryeri","2"),
                new ListItem("Bozüyük","3"),
                new ListItem("Söğüt","4"),
                new ListItem("Osmaneli","5"),
                new ListItem("Gölpazarı","6"),
                new ListItem("İnhisar","7"),
                new ListItem("Yenipazar","8")
                
                });
            }
            if (drp_il.SelectedValue == "16")
            {
                ilceler.AddRange(new List<ListItem>()
                {
                    new ListItem("Osmangazi","9"),
                    new ListItem("Yıldırım","10"),
                    new ListItem("Orhangazi","11"),
                    new ListItem("Gemlik","12"),
                    new ListItem("İnegöl","13"),
                    new ListItem("İznik","14")

                });
            }
            if (drp_il.SelectedValue == "44")
            {
                ilceler.AddRange(new List<ListItem>() { 
                new ListItem("Darende","15"),
                new ListItem("Kale","16"),
                new ListItem("Yeşilyurt","17"),
                new ListItem("Battalgazi","18"),
                new ListItem("Akçadağ","19")
                
                });

            }
            foreach(ListItem oge in ilceler)
            {
                drp_ilce.Items.Add(oge);
            }
        }
    }
}