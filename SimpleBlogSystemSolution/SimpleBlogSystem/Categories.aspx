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
                    <asp:LinkButton ID="CategoryLink" runat="server" Text='<%# Eval("CategoryName") %>' OnClick="CategoryLink_Click"></asp:LinkButton>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListViewPosts" runat="server">
        <LayoutTemplate>
            <div class="panel panel-default">
                <p runat="server" id="itemPlaceholder"></p>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <article>
                <div class="panel-body">
                    <h3><%#Eval("Title") %></h3>
                    <p><%#Eval("PostContent") %></p>
                    <p>Published by <b><%#Eval("User.UserName") %></b> on <%#Eval("PostDatePublished") %> </p>
                    <p>Last change on <%#Eval("PostLastModified") %></p>
                </div>
            </article>
        </ItemTemplate>
        <ItemSeparatorTemplate>
            <hr />
        </ItemSeparatorTemplate>
    </asp:ListView>
</asp:Content>
