<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="SimpleBlogSystem.Categories" %>


<asp:Content ID="CategoriesSideBar" ContentPlaceHolderID="SideBar" runat="server">
    <div class="col-sm-3 col-md-2 sidebar">
        <asp:ListView runat="server" ID="ListViewCategories">
            <LayoutTemplate>
                <ul class="nav nav-sidebar">
                    <p runat="server" id="itemPlaceholder"></p>
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>
                    <asp:Button ID="CategoryButton" runat="server" Text="<%#Eval("CategoryName") %>'><%#Eval("CategoryName") %>" OnClick="CategoryButton_Click" />
                </li>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListViewPosts" runat="server">
        <LayoutTemplate>
            <div class="jumbotron">
                <p runat="server" id="itemPlaceholder"></p>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <article>
                <h3><%#Eval("Title") %></h3>
                <p><%#Eval("PostContent") %></p>
                <p>Published by <%#Eval("User.UserName") %> at <%#Eval("PostDatePublished") %> </p>
                <p>Last change at <%#Eval("PostLastModified") %></p>
            </article>
        </ItemTemplate>
        <ItemSeparatorTemplate>
            <hr />
        </ItemSeparatorTemplate>
    </asp:ListView>
</asp:Content>
