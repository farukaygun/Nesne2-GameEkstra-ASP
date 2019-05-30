<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GameEkstra.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="login" class="Ortala">
        <div>
            <asp:Label ID="lblUyeGirisi" runat="server" Text="Üye Girişi"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox class="Kutu" ID="textBoxEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox class="Kutu" ID="textBoxSifre" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button class="Giris" ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
        </div>  
        <div>
            <asp:Button CssClass="YeniUye" ID="btnSignUp" runat="server" Text="Yeni Üyelik" OnClick="btnSignUp_Click" />
        </div>
    </div>
</asp:Content>
