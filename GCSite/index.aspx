<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GCSite.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Ana Sayfa</title>
    <link href="Store/StyleCss/indexCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="lines">
                <label style="font-size:30pt;">HoşGeldiniz</label>
                <asp:Button Text="Kayıt Ol" ID ="kayitBtn" runat="server" CssClass="Btns" OnClick="kayitBtn_Click"  Visible="true"/>
                <asp:Button Text="Giriş Yap" ID="girisBtn" runat="server"  CssClass="Btns" OnClick="girisBtn_Click" Visible="true"/>
                <asp:Button Text="Çıkış Yap" ID="cikisBtn" runat="server"  CssClass="Btns" OnClick="cikisBtn_Click" Visible="false"/>
                <asp:Label Text="Unknown" ID="lblNick" runat="server" CssClass="Btns"  Visible="false"/>
            </div>
            <div class="MainBox">
                
            </div>
        </div>
    </form>
</body>
</html>
