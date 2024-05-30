using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bilgisayar_programciligi
{
    public partial class hafta7_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

        protected void btn_geri_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex != 0)
            {
                MultiView1.ActiveViewIndex = MultiView1.ActiveViewIndex - 1;
            }
        }

        protected void btn_ileri_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex != MultiView1.Views.Count - 1)
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
            else if(MultiView1.ActiveViewIndex>0)
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

  

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            lbl_ad.Text = txt_ad.Text;
            lbl_soyad.Text = txt_soyad.Text;
            lbl_adres.Text = txt_adres.Text;
            lbl_bilgi.Text = "";

            if (gorsel.HasFile) {
                try {
                    if (gorsel.PostedFile.ContentType == "image/jpeg") {
                        string fileName = Path.GetFileName(gorsel.FileName);
                        if(fileName != "")
                        {
                            gorsel.SaveAs(Server.MapPath("~/images/")+fileName);
                            gorsel_cikti.ImageUrl = "/images/" + fileName;
                            gorsel_cikti_alternatif.Src = "/images/" + fileName;
                        }
                    } else
                    {
                        lbl_bilgi.Text = "JPEG formatında dosya yüklenmelidir.";
                    }
                }
                catch (Exception h) {

                    lbl_bilgi.Text = "Hata meydana geldi.";
                
                }
            }else {
                lbl_bilgi.Text = "Dosya bulunamadı.";
            }
        }
    }
}