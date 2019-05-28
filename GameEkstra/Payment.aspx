<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="GameEkstra.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="payment">
        <div>
            <asp:Label ID="lblNameAndSurname" runat="server" Text="Kart üzerindeki isim soyisim"></asp:Label>
            <asp:TextBox ID="textBoxCCNameSurname" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCCNO" runat="server" Text="Kart No"></asp:Label>
            <asp:TextBox ID="textBoxCCNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCCCCV" runat="server" Text="CCV"></asp:Label>
            <asp:TextBox ID="textBoxCCCCV" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSumbit" runat="server" Text="Alışverişi Tamamla" />
        </div>
    </div>
</asp:Content>
