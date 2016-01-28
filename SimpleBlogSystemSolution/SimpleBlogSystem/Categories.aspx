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
                    <a href='<%#Eval("CategoryName") %>'><%#Eval("CategoryName") %></a>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
