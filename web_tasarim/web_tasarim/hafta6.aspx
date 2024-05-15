<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta6.aspx.cs" Inherits="web_tasarim.hafta6" %>

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
                    <td>
                        <asp:DropDownList runat="server" ID="il" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="il_SelectedIndexChanged">
                            <asp:ListItem Value="-1">-- İl seçin--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList runat="server" ID="ilce" Width="150px">
                            <asp:ListItem Value="-1">-- İlçe seçin--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
