<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta8.aspx.cs" Inherits="web_tasarim.hafta8" %>

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
                    <td>Ad:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_ad"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Soyad:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_soyad" />
                    </td>
                </tr>
                <tr>
                    <td>Mezuniyet</td>
                    <td>
                        <asp:RadioButton runat="server" GroupName="mezuniyet" ID="mezuniyet1" Text="Lise" />
                        <asp:RadioButton runat="server" GroupName="mezuniyet" ID="mezuniyet2" Text="Önlisans" />
                        <asp:RadioButton runat="server" GroupName="mezuniyet" ID="mezuniyet3" Text="Lisans" />
                        <asp:RadioButton runat="server" GroupName="mezuniyet" ID="mezuniyet4" Text="Yüksek Lisans" />
                    </td>
                </tr>
                <tr>
                    <td>Cinsiyet</td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="cinsiyet">
                            <asp:ListItem Text="Kadın" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Erkek" Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                    Bildiğiniz Diller (Bilgisayar)
                    </td>
                    <td>
                        <asp:CheckBox runat="server" ID="dil1" Text="PHP" />
                        <asp:CheckBox runat="server" ID="dil2" Text="C++" />
                        <asp:CheckBox runat="server" ID="dil3" Text="Python" />
                        <asp:CheckBox runat="server" ID="dil4" Text="C#" />
                        <asp:CheckBox runat="server" ID="dil5" Text="F#" />
                        <asp:CheckBox runat="server" ID="dil6" Enabled="false" Text="Pascal" />
                    </td>
                    </tr>
                <tr>
                    <td>Yabancı Diller</td>
                    <td>
                        <asp:CheckBoxList runat="server" ID="yabanciDil">
                            <asp:ListItem Text="İngilizce" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Almanca" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Arapça" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Rusça" Value="4"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btn_kaydet" Text="Kaydet" OnClick="btn_kaydet_Click" />

                    </td>
                    <td>
                        ...
                    </td>
                </tr>
            </table>
            <hr />
            <table>
                <tr>
                    <td>Ad:</td>
                    <td>
                        <asp:Label runat="server" ID="lbl_ad"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Soyad</td>
                    <td>
                        <asp:Label ID="lbl_soyad" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        Mezuniyet
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lbl_mezuniyet"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Cinsiyet</td>
                    <td><asp:Label runat="server" ID="lbl_cinsiyet"></asp:Label></td>
                </tr>
                <tr>
                    <td>Bildiğiniz Diller(Bilgisayar)</td>
                    <td><asp:Label runat="server" ID="lbl_dil_bilgisayar"></asp:Label></td>
                </tr>
                <tr>
                    <td>Yabancı Diller</td>
                    <td><asp:Label runat="server" ID="lbl_yabanci_diller"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
