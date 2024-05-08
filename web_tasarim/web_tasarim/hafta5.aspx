<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta5.aspx.cs" Inherits="web_tasarim.hafta5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr> 
                    <td rowspan="2">
                        <asp:ListBox runat="server" ID="lst_havuz" Height="250px" Width="150px" SelectionMode="Multiple">
                            <asp:ListItem Value="11">Bilecik</asp:ListItem>
                            <asp:ListItem Value="16">Bursa</asp:ListItem>
                            <asp:ListItem Value="10">Balıkesir</asp:ListItem>
                            <asp:ListItem Value="34">İstanbul</asp:ListItem>
                            <asp:ListItem Value="06">Ankara</asp:ListItem>
                            <asp:ListItem Value="44">Malatya</asp:ListItem>
                            <asp:ListItem Value="46">Kahramanmaraş</asp:ListItem>
                            <asp:ListItem Value="35">İzmir</asp:ListItem>
                            <asp:ListItem Value="63">Şanlıurfa</asp:ListItem>
                            <asp:ListItem Value="55">Samsun</asp:ListItem>
                            <asp:ListItem Value="02">Adıyaman</asp:ListItem>
                        </asp:ListBox><br />
                        <asp:Label runat="server" ID="lbl_havuz_bilgi"></asp:Label>
                    </td>
                     <td><asp:Button runat="server" ID="btn_ekle" Text="Ekle" OnClick="btn_ekle_Click" /></td>
                       <td rowspan="2">
                       <asp:ListBox runat="server" ID="lst_secim" SelectionMode="Multiple" Width="150px" Height="250px">

                       </asp:ListBox><br />
                           <asp:Label runat="server" ID="lbl_secim_bilgi"></asp:Label>
                   </td>
                </tr>
                <tr>                 
                    <td><asp:Button runat="server" ID="btn_cikar" Text="Çıkar" OnClick="btn_cikar_Click" /></td>
                </tr>
                <tr>
                    <td colaspan="3">
                        <asp:Label runat="server" ID="lbl_bilgi"></asp:Label>
                    </td>
                </tr>
                

            </table>
        </div>
    </form>
</body>
</html>
