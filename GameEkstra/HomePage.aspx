<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="GameEkstra.HomePage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="CSS.css">
    <div class="UrunAlanı">
    <asp:Image class="UrunFoto" ID="Image1" ImageURL="./images/1.jpg" runat="server" />
    <asp:Label Class="UrunYazısı" ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label Class="UrunFiyat" ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Button Class="SepeteEkle" ID="Button1" runat="server" Text="Satın Al" OnClick="Button1_Click" />
    </div>
    <div class="UrunAlanı">
    <asp:Image class="UrunFoto" ID="Image2" ImageURL="./images/2.jpg" runat="server" />
    <asp:Label Class="UrunYazısı" ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Label Class="UrunFiyat" ID="Label4" runat="server" Text="Label"></asp:Label>
    <asp:Button Class="SepeteEkle" ID="Button2" runat="server" Text="Satın Al" OnClick="Button2_Click" />
    </div>
    <div class="UrunAlanı">
    <asp:Image class="UrunFoto" ID="Image3" ImageURL="./images/3.jpg" runat="server" />
    <asp:Label Class="UrunYazısı" ID="Label5" runat="server" Text="Label"></asp:Label>
    <asp:Label Class="UrunFiyat" ID="Label6" runat="server" Text="Label"></asp:Label>
    <asp:Button Class="SepeteEkle" ID="Button3" runat="server" Text="Satın Al" OnClick="Button3_Click" />
    </div>
    <div class="UrunAlanı">
    <asp:Image class="UrunFoto" ID="Image4" ImageURL="./images/4.jpg" runat="server" />
    <asp:Label Class="UrunYazısı" ID="Label7" runat="server" Text="Label"></asp:Label>
    <asp:Label Class="UrunFiyat" ID="Label8" runat="server" Text="Label"></asp:Label>
    <asp:Button Class="SepeteEkle" ID="Button4" runat="server" Text="Satın Al" OnClick="Button4_Click" />
    </div>
    <div class="UrunAlanı">
    <asp:Image class="UrunFoto" ID="Image5" ImageURL="./images/5.jpg" runat="server" />
    <asp:Label Class="UrunYazısı" ID="Label9" runat="server" Text="Label"></asp:Label>
    <asp:Label Class="UrunFiyat" ID="Label10" runat="server" Text="Label"></asp:Label>
    <asp:Button Class="SepeteEkle" ID="Button5" runat="server" Text="Satın Al" OnClick="Button5_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Button Class="Sepet" ID="btnMyCart" Text="Sepetim" runat="server" OnClick="btnMyCart_Click" /> <asp:Button Class="CikisYap" ID="btnCikis" runat="server" Text="Çıkış Yap" OnClick="btnCikis_Click" />
    <asp:Button Class="UyeGirisi" ID="btnLogin" Text="Giriş Yap" runat="server" OnClick="btnLogin_Click" />
</asp:Content>
                        
