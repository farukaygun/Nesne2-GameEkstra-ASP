<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GameEkstra.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="login">
        <div>
            <asp:Label ID="lblUyeGirisi" runat="server" Text="Üye Girişi"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="textBoxEmail" runat="server" Text="Email"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="textBoxSifre" runat="server" Text="Şifre"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
        </div>  
        <div>
            <asp:Button ID="btnSignUp" runat="server" Text="Yeni Üyelik" OnClick="btnSignUp_Click" />
        </div>
    </div>
</asp:Content>
