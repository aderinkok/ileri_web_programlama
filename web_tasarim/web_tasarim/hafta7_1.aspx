<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta7_1.aspx.cs" Inherits="web_tasarim.hafta7_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">
            <asp:View runat="server" ID="asama1">
                Ad: <asp:TextBox runat="server" ID="txt_ad"></asp:TextBox><br />
                Soyad: <asp:TextBox runat="server" ID="txt_soyad"></asp:TextBox><br />
                Adres:<asp:TextBox runat="server" ID="txt_adres" TextMode="MultiLine"></asp:TextBox>

            </asp:View>
            <asp:View runat="server" ID="asama2">
                Görsel: <asp:FileUpload runat="server" ID="gorsel" />

                <br /><br />
                <asp:Button ID="kaydet" runat="server" Text="Kaydet" OnClick="kaydet_Click" />

            </asp:View>
            <asp:View runat="server" ID="asama3">
                Ad: <asp:Label runat="server" Text="" ID="lbl_ad"></asp:Label><br />
                Soyad: <asp:Label runat="server" Text="" ID="lbl_soyad"></asp:Label><br />
                Adres: <asp:Label runat="server" Text="" ID="lbl_adres"></asp:Label><br />
                Görsel: <asp:Image runat="server" ID="gorsel_cikti" Width="200px" Height="200px" /><br />
                <br />
                Görsel (Alternatif): <img id="gorsel_cikti_alternatif" runat="server" width="200" height="200" />
            </asp:View>

        </asp:MultiView>

        <br />
        <hr />
        <asp:Button runat="server" ID="btn_geri" OnClick="btn_geri_Click" Text="Geri" />
        <asp:Button runat="server" ID="btn_ileri" OnClick="btn_ileri_Click" Text="İleri" />
        
    </form>
</body>
</html>
