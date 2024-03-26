<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta2.aspx.cs" Inherits="web_tasarim.hafta2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="4">
                        <asp:TextBox ID="Hesap" runat="server" Height="50px" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
    <td colspan="4">
        <asp:Label runat="server" ID="cikti" Text=""></asp:Label>
    </td>
</tr>
                <tr>
                    <td><asp:Button ID="Yedi" runat="server" Height="50px" Text="7" Width="50px" OnClick="Yedi_Click" /></td>
                    <td><asp:Button ID="Sekiz" runat="server" Height="50px" Text="8" Width="50px" OnClick="Sekiz_Click" /></td>
                    <td><asp:Button ID="Dokuz" runat="server" Height="50px" Text="9" Width="50px" OnClick="Dokuz_Click" /></td>
                    <td>
                        <asp:Button ID="Bolme" Text="/" runat="server" Height="50px" Width="50px" OnClick="Bolme_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Dort" runat="server" Height="50px" Text="4" Width="50px" OnClick="Dort_Click" /></td>
                    <td><asp:Button ID="Bes" runat="server" Height="50px" Text="5" Width="50px" OnClick="Bes_Click" /></td>
                    <td><asp:Button ID="Alti" runat="server" Height="50px" Text="6" Width="50px" OnClick="Alti_Click" /></td>
                    <td>
                        <asp:Button ID="Carpma" Text="X" runat="server" Height="50px" Width="50px" OnClick="Carpma_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Bir" runat="server" Height="50px" Text="1" Width="50px" OnClick="Bir_Click" /></td>
                    <td><asp:Button ID="Iki" runat="server" Height="50px" Text="2" Width="50px" OnClick="Iki_Click" /></td>
                    <td><asp:Button ID="Uc" runat="server" Height="50px" Text="3" Width="50px" OnClick="Uc_Click" /></td>
                    <td>
                        <asp:Button ID="Cikarma" runat="server" Text="-" Height="50px" Width="50px" OnClick="Cikarma_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Sifir" runat="server" Height="50px" Text="0" Width="50px" OnClick="Sifir_Click" /></td>
                    <td colspan="2"><asp:Button ID="Esittir" runat="server" Height="50px" Text="=" Width="100px" OnClick="Esittir_Click" /></td>
                    <td>
                        <asp:Button ID="Toplama" runat="server" Height="50px" Text="+" Width="50px" OnClick="Toplama_Click" />
                    </td>
                </tr>


            </table>
        </div>
    </form>
</body>
</html>
