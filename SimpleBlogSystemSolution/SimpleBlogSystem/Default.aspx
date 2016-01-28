<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleBlogSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="jumbotron">
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
                <p>Published by <%#Eval("User.UserName") %> on <%#Eval("PostDatePublished") %> </p>
                <p>Last change on <%#Eval("PostLastModified") %></p>
            </article>
        </ItemTemplate>
        <ItemSeparatorTemplate>
            <hr />
        </ItemSeparatorTemplate>
    </asp:ListView>
	</div>
</asp:Content>
