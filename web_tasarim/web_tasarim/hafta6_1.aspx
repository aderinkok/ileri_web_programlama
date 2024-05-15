<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta6_1.aspx.cs" Inherits="web_tasarim.hafta6_1" %>

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
                    <td>Ad: </td>
                    <td><asp:TextBox runat="server" ID="txt_ad"></asp:TextBox></td>
                </tr>
                 <tr>
                 <td>Soyad: </td>
                 <td><asp:TextBox runat="server" ID="txt_soyad"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Cinsiyet</td>
                     <td><asp:DropDownList runat="server" ID="drp_cinsiyet" AutoPostBack="true" OnSelectedIndexChanged="drp_cinsiyet_SelectedIndexChanged">
                         <asp:ListItem Text="--Seçiniz--" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Kadın" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Erkek" Value="1"></asp:ListItem>
                         </asp:DropDownList></td>
                 </tr>
                <tr runat="server" id="askerlikPanel" visible="false">
                    <td>
                       Askerlik 
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="drp_asker">
                             <asp:ListItem Text="--Seçiniz--" Value="-1"></asp:ListItem>
                             <asp:ListItem Text="Yaptı" Value="0"></asp:ListItem>
                             <asp:ListItem Text="Tecilli" Value="1"></asp:ListItem>
                             <asp:ListItem Text="Muaf" Value="2"></asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>Bilgilerimin KVKK kapsamında işlenmesini kabul ediyorum.</td>
                    <td>
                        <asp:DropDownList runat="server" ID="drp_kvkk" AutoPostBack="true" OnSelectedIndexChanged="drp_kvkk_SelectedIndexChanged">
                            <asp:ListItem Text="--Seçiniz--" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Evet" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Hayır" Value="0"></asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" ID="btn_kaydet" Text="Kaydet" Enabled="false" OnClick="btn_kaydet_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
