<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta2.aspx.cs" Inherits="bilgisayar_programciligi.hafta2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table>
     <tr>
         <td colspan="4">
             <asp:TextBox ID="Islem" runat="server" Width="100%" Height="50px"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td colspan="4">
             
             <asp:Label ID="Cikti" runat="server" Text=""></asp:Label>
             
         </td>
     </tr>
     <tr>
         <td><asp:Button ID="Yedi" runat="server" Text="7" Height="50px" Width="50px" OnClick="Yedi_Click" /></td>
         <td><asp:Button ID="Sekiz" runat="server" Text="8" Height="50px" Width="50px" OnClick="Sekiz_Click" /></td>
         <td><asp:Button ID="Dokuz" runat="server" Text="9" Height="50px" Width="50px" OnClick="Dokuz_Click" /></td>
         <td><asp:Button ID="Bolme" runat="server" Text="/" Height="50px" Width="50px" OnClick="Bolme_Click" /></td>
     </tr>
     <tr>
         <td><asp:Button ID="Dort" runat="server" Text="4" Height="50px" Width="50px" OnClick="Dort_Click" /></td>
         <td><asp:Button ID="Bes" runat="server" Text="5" Height="50px" Width="50px" OnClick="Bes_Click" /></td>
         <td><asp:Button ID="Alti" runat="server" Text="6" Height="50px" Width="50px" OnClick="Alti_Click" /></td>
         <td><asp:Button ID="Carpma" runat="server" Text="X" Height="50px" Width="50px" OnClick="Carpma_Click" /></td>
     </tr>
     <tr>
         <td><asp:Button ID="Bir" runat="server" Text="1" Height="50px" Width="50px" OnClick="Bir_Click" /></td>
         <td><asp:Button ID="Iki" runat="server" Text="2" Height="50px" Width="50px" OnClick="Iki_Click" /></td>
         <td><asp:Button ID="Uc" runat="server" Text="3" Height="50px" Width="50px" OnClick="Uc_Click" /></td>
         <td><asp:Button ID="Cikarma" runat="server" Text="-" Height="50px" Width="50px" OnClick="Cikarma_Click" /></td>
     </tr>
     <tr>
         <td><asp:Button ID="Sifir" runat="server" Text="0" Height="50px" Width="50px" OnClick="Sifir_Click" /></td>
         <td colspan="2">
             <asp:Button ID="Esittir" runat="server" Height="50px" Text="=" Width="100px" OnClick="Esittir_Click" />
         </td>
         <td>
             <asp:Button ID="Toplama" runat="server" Text="+" Height="50px" Width="50px" OnClick="Toplama_Click" />
         </td>
     </tr>
 </table>
    </form>
</body>
</html>
