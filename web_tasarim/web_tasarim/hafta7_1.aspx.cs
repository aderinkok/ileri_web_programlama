using System;
using System.Collections.Generic;
using System.IO;
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
            if (MultiView1.ActiveViewIndex != MultiView1.Views.Count-1)
            {
                MultiView1.ActiveViewIndex += 1;
            }
            if (gorsel.HasFile) {
                lbl_bilgi.Text = "";
                try { 
                
                    if(gorsel.PostedFile.ContentType == "image/jpeg")
                    {
                        Response.Write(gorsel.PostedFile.ContentType);
                        string fileName = Path.GetFileName(gorsel.FileName);
                        if(fileName != "")
                        {
                            gorsel.SaveAs(Server.MapPath("~/images/") + fileName);

                            lbl_ad.Text = txt_ad.Text;
                            lbl_soyad.Text = txt_soyad.Text;
                            lbl_adres.Text = txt_adres.Text;

                            gorsel_cikti.ImageUrl = "/images/" + fileName;
                            gorsel_cikti_alternatif.Src = "/images/" + fileName;
                        }
                    }
                    else
                    {
                        lbl_bilgi.Text = "JPEG formatında dosya yüklenmelidir.";
                    }
                }
                catch (Exception h) { 
                
                
                }
             



            } else
            {
                lbl_bilgi.Text = "Dosya bulunamadı";
            }
            
           
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