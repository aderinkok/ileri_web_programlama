<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta7.aspx.cs" Inherits="web_tasarim.hafta7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Başlangıç Tarihi<asp:Calendar ID="baslangic_tarihi" runat="server" OnDayRender="baslangic_tarihi_DayRender"></asp:Calendar>
            <br />
            <br />
            Bitiş Tarihi<br />
            <asp:Calendar runat="server" ID="bitis_tarihi" OnDayRender="bitis_tarihi_DayRender"></asp:Calendar><br />

            <asp:Button Text="İki tarih arasındaki farkı hesapla" ID="hesapla" OnClick="hesapla_Click" runat="server" />
            <br />
            <asp:Label runat="server" ID="cikti"></asp:Label>
        </div>
    </form>
</body>
</html>
