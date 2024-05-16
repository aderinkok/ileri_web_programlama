<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hafta6.aspx.cs" Inherits="bilgisayar_programciligi.hafta6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="drp_il" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="drp_il_SelectedIndexChanged">
                <asp:ListItem Value="-1">-- Seçin --</asp:ListItem>

            </asp:DropDownList>

            <br />

            <asp:DropDownList runat="server" ID="drp_ilce" Width="150px">
                <asp:ListItem Value="-1">-- Seçin --</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
