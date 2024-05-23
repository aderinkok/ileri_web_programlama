<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta7.aspx.cs" Inherits="bilgisayar_programciligi.hafta7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="baslangic_tarihi" runat="server" OnDayRender="baslangic_tarihi_DayRender"></asp:Calendar><br />
            <asp:Calendar ID="bitis_tarihi" runat="server" OnDayRender="bitis_tarihi_DayRender"></asp:Calendar><br />
            <asp:Button Text="İki Tarih arasındaki farkı hespla" ID="hesapla" OnClick="hesapla_Click" runat="server" /><br />
            <asp:Label Text="" runat="server" ID="cikti" />
        </div>
    </form>
</body>
</html>
