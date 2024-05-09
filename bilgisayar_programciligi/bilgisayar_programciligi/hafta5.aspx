<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta5.aspx.cs" Inherits="bilgisayar_programciligi.hafta5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td rowspan="2">
                        <asp:ListBox runat="server" ID="lst_havuz" Height="250px" SelectionMode="Multiple" Width="150px">
                            <asp:ListItem Value="11">Bilecik</asp:ListItem>
                            <asp:ListItem Value="16">Bursa</asp:ListItem>
                            <asp:ListItem Value="10">Balıkesir</asp:ListItem>
                            <asp:ListItem Value="34">İstanbul</asp:ListItem>
                            <asp:ListItem Value="06">Ankara</asp:ListItem>
                            <asp:ListItem Value="35">İzmir</asp:ListItem>
                            <asp:ListItem Value="44">Malatya</asp:ListItem>
                            <asp:ListItem Value="26">Eskişehir</asp:ListItem>
                            <asp:ListItem Value="41">Kocaeli</asp:ListItem>
                            <asp:ListItem Value="54">Sakarya</asp:ListItem>
                            <asp:ListItem Value="61">Trabzon</asp:ListItem>
                        </asp:ListBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_havuz_bilgi"></asp:Label>
                    </td>
                               
                    <td><asp:Button runat="server" ID="btn_ekle" Text="Ekle" OnClick="btn_ekle_Click"  /></td>
                     
                     <td rowspan="2">
                         <asp:ListBox runat="server" ID="lst_secim" Height="250px" Width="150px" SelectionMode="Multiple">

                         </asp:ListBox>
                         <br />
                           <asp:Label runat="server" ID="lbl_secim_bilgi"></asp:Label>
                     </td>
                   
                </tr>
                <tr><td><asp:Button runat="server" ID="btn_cikar" Text="Çıkar" OnClick="btn_cikar_Click" /></td></tr>
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
