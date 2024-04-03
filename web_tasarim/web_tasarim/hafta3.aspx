<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta3.aspx.cs" Inherits="web_tasarim.hafta3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:TextBox runat="server" ID="SatirSayisi" placeholder="Satır Sayısı" Height="30px" Width="100px"></asp:TextBox></td>
                <td><asp:TextBox runat="server" ID="SutunSayisi" placeholder="Sütun Sayısı" Height="30px" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                     <asp:Button runat="server" Width="200px" ID="Olustur" Text="Tablo Oluştur" OnClick="Olustur_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="Bilgi" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Table runat="server" ID="Tablo1"></asp:Table>
                </td>
            </tr>
        </table>
       
         
       
     </form>
</body>
</html>
