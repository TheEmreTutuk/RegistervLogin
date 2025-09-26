<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GCSite.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Giriş Yap</title>
    <link href="Store/StyleCss/LoginCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="MainBox">
                <h1 style="font-size:30pt">Giriş</h1>
                <label class="Nams">Nick ismi:</label><br />
                <asp:TextBox runat="server" ID="tbNick" CssClass="TextBtns"/> <br />
                <label class="Nams">Şifre:</label><br />
                <div>
                    <asp:TextBox runat="server" ID="tbPassword" CssClass="TextBtns" type="Password"/>
                </div>
                <br />
                <asp:Label ID="loginMesaj" runat="server" CssClass="msj" Visible="false"/> <br />
                <asp:Button ID="loginbtn" Text="Giriş Yap" runat="server" CssClass="TextBtns" OnClick="loginbtn_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
