<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta7_1.aspx.cs" Inherits="bilgisayar_programciligi.hafta7_1" %>

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
                Adres: <asp:TextBox runat="server" ID="txt_adres" TextMode="MultiLine"></asp:TextBox>
            </asp:View>
            <asp:View runat="server" ID="asama2">
                Görsel: <asp:FileUpload ID="gorsel" runat="server" />
                <asp:Button Text="Kaydet" ID="btn_kaydet" OnClick="btn_kaydet_Click" runat="server" />
            </asp:View>
            <asp:View runat="server" ID="asama3">
                Bilgi: <asp:Label runat="server" ID="lbl_bilgi"></asp:Label><br />
                Ad: <asp:Label Text="" ID="lbl_ad" runat="server" /><br />
                Soyad: <asp:Label Text="" ID="lbl_soyad" runat="server" /><br />
                Adres: <asp:Label Text="" ID="lbl_adres" runat="server" /><br />
                Görsel: <asp:Image ID="gorsel_cikti" runat="server"  Height="200px" Width="200px"/><br />
                Görsel(Alternatif): <img runat="server" id="gorsel_cikti_alternatif" height="200" width="200" />


            </asp:View>
        </asp:MultiView><br />
        <hr />
        <asp:Button runat="server" ID="btn_geri" Text="Geri" OnClick="btn_geri_Click" />
        <asp:Button runat="server" ID="btn_ileri" Text="İleri" OnClick="btn_ileri_Click" />
    </form>
</body>
</html>
