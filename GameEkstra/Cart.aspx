<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="GameEkstra.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cartDetail">
        <div>
            <asp:ListView ID="listViewCart" runat="server"></asp:ListView>
        </div>
        <div>
            <asp:Button ID="btnSumbit" runat="server" Text="Alışverişi Tamamla" />
        </div>
    </div>
</asp:Content>
