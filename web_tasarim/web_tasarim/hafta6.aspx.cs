using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_tasarim
{
    public partial class hafta6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            
            List<ListItem> iller = new List<ListItem>() {
            
            new ListItem("Bilecik","11"),
            new ListItem("Malatya","44"),
            new ListItem("Bursa","16"),

            };

            foreach(ListItem oge in iller)
            {
                il.Items.Add(oge);
            }
            }

        }

        protected void il_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListItem> ilceler = new List<ListItem>();
            ilceler.Clear();
            ilce.Items.Clear();
            if (il.SelectedValue == "-1") { }

            if (il.SelectedValue == "11") {

                ilceler.AddRange(new List<ListItem>{
                new ListItem("Merkez","1"),
                new ListItem("Pazaryeri","2"),
                new ListItem("Bozüyük","3"),
                new ListItem("Söğüt","4"),
                new ListItem("Osmaneli","5"),
                new ListItem("Yenipazar","6"),
                new ListItem("İnhisar","7"),
                new ListItem("Gölpazarı","8"),
                }) ;
            
            }
            if (il.SelectedValue == "44") {
                ilceler.AddRange(new List<ListItem> { 
                
                new ListItem("Battalgaz,","9"),
                new ListItem("Yeşilyurt","10"),
                new ListItem("Darende","11"),
                new ListItem("Akçadağ","12")
                });
            
            }
            if (il.SelectedValue == "16") {
                ilceler.AddRange(new List<ListItem> {
                new ListItem("Yıldırım","13"),
                new ListItem("Osmangazi","14"),
                new ListItem("İnegöl","15"),
                new ListItem("Nilüfer","16"),
                new ListItem("Yenişehir","17"),
                
                });
            
                   
            }


            foreach(ListItem oge in ilceler)
            {
                ilce.Items.Add(oge);
            }
        }
    }
}