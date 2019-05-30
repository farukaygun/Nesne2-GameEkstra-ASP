<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="GameEkstra.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cartDetail">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GameEkstraDatabaseConnectionString %>" SelectCommand="SELECT [name], [price] FROM [tblSepet]"></asp:SqlDataSource>
            <asp:Label ID="Label1" runat="server" Text="Toplam:"></asp:Label><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
            <asp:Button ID="btnSumbit" runat="server" Text="Alışverişi Tamamla" OnClick="btnSumbit_Click" /><asp:Button ID="btnTemizle" runat="server" Text="Sepeti Boşalt" OnClick="btnTemizle_Click" />
        </asp:Content>
