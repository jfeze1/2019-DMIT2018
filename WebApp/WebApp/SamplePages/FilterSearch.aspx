<%@ Page Title="Filter Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilterSearch.aspx.cs" Inherits="WebApp.SamplePages.FilterSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Filter Search</h1>
    <blockquote class="alert alert-info">
        This page will review filter search techniques. This page will be using code behind and ObjectDataSource on multi-record controls. This page will use various form controls. This will review event driven logic
    </blockquote>
    <div class="col-md-offset-3">
        <asp:Label ID="Message" runat="server"></asp:Label>
        <asp:Label ID="label5" runat="server" Text="Select an artist:"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="ArtistList" runat="server"></asp:DropDownList>
        <asp:LinkButton ID="FetchAlbums" runat="server" Text="Fetch Album">LinkButton</asp:LinkButton>
        <br />

        <asp:GridView ID="AlbumList" runat="server"></asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Album ID"></asp:Label>
        <asp:Label ID="AlbumID" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Label ID="Label3" runat="server" Text="Album ID"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;

    </div>

    <asp:ObjectDataSource ID="AlbumListODS" runat="server">

    </asp:ObjectDataSource>

    <asp:ObjectDataSource ID="AlbumArtistListODS" runat="server"></asp:ObjectDataSource>
    
</asp:Content>
