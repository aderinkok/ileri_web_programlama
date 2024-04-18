<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta4.aspx.cs" Inherits="bilgisayar_programciligi.hafta4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="liste" runat="server">
         
            </asp:ListBox>

            <br />

            <asp:TextBox ID="txt_isim" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="btn_ekle" runat="server" Text="Ekle" OnClick="btn_ekle_Click"/>
            <br />
            <asp:Button ID="btn_sil" runat="server" Text="Sil" OnClick="btn_sil_Click"/>

        </div>
    </form>
</body>
</html>
