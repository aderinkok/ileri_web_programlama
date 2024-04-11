<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta3.aspx.cs" Inherits="bilgisayar_programciligi.hafta3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr>
               <td>
                   <asp:TextBox runat="server" ID="satirSayisi" Height="30px" placeholder="Satır Sayısı"></asp:TextBox>
               </td>
               <td>
                   <asp:TextBox runat="server" ID="sutunSayisi" Height="30px" placeholder="Sütun Sayısı"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td colspan="2">
                   <asp:Label ID="Bilgi" Text="" runat="server" />
               </td>
           </tr>
           <tr>
               <td colspan="2">
                   <asp:Button runat="server" Width="100%" Height="30px" ID="olustur" Text="Tablo Oluştur" OnClick="olustur_Click" />
               </td>
           </tr>
           <tr>
               <td colspan="2">
                  
                   <asp:Table ID="Tablo" runat="server">
                   </asp:Table>
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
