<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="GameEkstra.SignUp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="signUp">
        <div>
            <asp:Label ID="lblNewMember" runat="server" Text="Yeni Üyelik"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text="Adı"></asp:Label>
            <asp:TextBox ID="textBoxName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblSurname" runat="server" Text="Soyadı"></asp:Label>
            <asp:TextBox ID="textBoxSurname" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblTCNO" runat="server" Text="TC No"></asp:Label>
            <asp:TextBox ID="textBoxTCNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="textBoxEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox ID="textBoxPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblGender" runat="server" Text="Cinsiyet"></asp:Label>
            <asp:RadioButton ID="radioButtonMale" Text="Erkek" runat="server" />
            <asp:RadioButton ID="radioButtonFemale" Text="Kadın" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPhone" runat="server" Text="Telefon"></asp:Label>
            <asp:TextBox ID="textBoxPhone" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAddress" runat="server" Text="Adres"></asp:Label>
            <asp:TextBox ID="textBoxAddress" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSignUp" runat="server" Text="Üye Ol" OnClick="btnSignUp_Click" />
        </div>
    </div>
</asp:Content>
