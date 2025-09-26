<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GCSite.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kayıt Ol</title>
    <link href="Store/StyleCss/LoginCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="MainBox">
                <h1 style="font-size:30pt">Kayıt Ol</h1>
                <label class="Nams">Nick isminiz:</label><br />
                <asp:TextBox runat="server" ID="tbNick" CssClass="TextBtns"/> <br />
                <label class="Nams">Mailiniz:</label> <br />
                <asp:TextBox runat="server" ID="tbMail" CssClass="TextBtns"/> <br />
                <label class="Nams">Şifre:</label><br />
                <div>
                    <asp:TextBox runat="server" ID="tbPassword" CssClass="TextBtns" type="Password"/>
                </div>
                <br />
                <asp:Label ID="registerMesaj" runat="server" CssClass="msj" Visible="false"/> <br />
                <asp:Button Text="Kayıt OL!" runat="server" CssClass="TextBtns" OnClick="Unnamed_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
